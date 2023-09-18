using App.Dto.Airport;
using App.Dto.Default;
using AutoMapper;
using Context.Repo;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Util;


namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly ContextApp _context;
        private readonly IMapper _mapper;

        public AirportController(ContextApp context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("List/")]
        public ActionResult<ICollection<AirportResponseDto>> List(DefaultRequestDto request)
        {
            try
            {
                request.QtyByPage = request.QtyByPage == 0 ? 99999 : request.QtyByPage;
                request.Page = request.Page == 0 ? 1 : request.Page;
                request.Skip = (request.Page - 1) * request.QtyByPage;

                var query = _context.Airport
                    .Where(o => !o.Deleted
                        && (string.IsNullOrEmpty(request.Filter)
                            || o.AirportName.ToLower().Contains(request.Filter.ToLower())
                            || o.ICAO.ToLower().Contains(request.Filter.ToLower())
                            )
                        )
                    .OrderByDescending(o => o.Id);

                var totalList = query.Count();
                var result = query.Skip(request.Skip).Take(request.QtyByPage).ToList();
                double totalPage = Math.Ceiling(totalList / (double)request.QtyByPage);
             
                var oMapped = _mapper.Map<IEnumerable<Airport>, IEnumerable<AirportResponseDto>>(result);

                return Ok(new SuccessControlledList
                {
                    Status = true,
                    Code = "success",
                    Pagination = new PaginationControlled
                    {
                        TotalRegister = totalList,
                        TotalPage = totalPage,
                        ActualPage = request.Page,
                        QtyByPage = request.QtyByPage,
                    },
                    Data = oMapped
                });
            }
            catch (ExceptionControlled ex)
            {
                return BadRequest(ex.ResponseToJson());
            }
            catch (Exception ex)
            {

                return BadRequest(ExceptionControlled.ResponseToJson(ex));
            }
        }

    }
}

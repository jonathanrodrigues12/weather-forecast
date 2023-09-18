using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class SuccessControlled
    {
        public bool Status { get; set; } = true;
        public string Code { get; set; } = "success";
        public object? Data { get; set; }
    }
    public class SuccessControlledWithoutData
    {
        public bool Status { get; set; } = true;
        public string Code { get; set; } = "success";
    }

    public class SuccessControlledList
    {
        public bool Status { get; set; } = true;
        public string Code { get; set; } = "success";
        public PaginationControlled Pagination { get; set; }
        public object? Data { get; set; }

    }
    public class SuccessControlledListWithS3
    {
        public bool Status { get; set; } = true;
        public string Code { get; set; } = "success";
        public string BaseUrlimage { get; set; }
        public PaginationControlled Pagination { get; set; }
        public object? Data { get; set; }

    }

    public class PaginationControlled
    {
        public int TotalRegister { get; set; }
        public double TotalPage { get; set; }
        public int ActualPage { get; set; }
        public int QtyByPage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class Operation
    {
        public int Id { get; set; }

        public Car Car { get; set; }
        public int CarId { get; set; }
        public Employee Performer { get; set; }
        public int PerformerId { get; set; }
        public OperationType OperationType { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public OperationStatus Status { get; set; }
        public decimal? Cost { get; set; }
    }
}

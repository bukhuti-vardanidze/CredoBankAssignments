﻿namespace BonusManagementSystem_Api.Db.Entity
{
    public class BonusEntity
    {
        public int Id { get; set; }
        public int recomendtorId { get; set; }
        public double BonusQuantity { get; set; }
        public DateTime BonusIssueTime { get; set; }
       public EmployeeEntity EmployeeEntity { get; set; }
    }
}

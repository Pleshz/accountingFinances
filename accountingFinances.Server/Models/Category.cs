﻿namespace accountingFinances.Server.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperationType Type { get; set; }
    }
    public enum OperationType 
    {
        income,
        expence
    }
}

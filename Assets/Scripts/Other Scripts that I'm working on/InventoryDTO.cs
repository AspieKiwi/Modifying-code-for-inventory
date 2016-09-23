using System;
using SQLite4Unity3d;

public class InventoryDTO
{
    [PrimaryKey]
    [AutoIncrement]
    public int InventoryID { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public InventoryDTO( string Name, DateTime Date, int InventoryID)
    {
        this.InventoryID = InventoryID;
        this.Date = Date;
        this.Name = Name;
    }
}

public class PlayerInventoryDTO
{
    [PrimaryKey]
    [AutoIncrement]
    public int ID { get; set; }
    public int PlayerID { get; set; }
    public int InventoryID { get; set; }
}


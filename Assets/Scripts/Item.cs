using System;
using System.Collections.Generic;

public class Item
	{

    public Item _item = new Item();
    public string ItemName;
    private DateTime date;

    public string iName
    {
        get
        {
            return ItemName;
        }

        set
        {
            ItemName = value;
        }
    }

    public DateTime Date
    {
        get
        {
            return date;
        }

        set
        {
            date = value;
        }
    }
}



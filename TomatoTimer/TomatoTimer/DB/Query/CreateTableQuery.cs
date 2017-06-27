using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoTimer
{
    public class CreateTableQuery
    {
        public const string T_CUSTOMER = @"
            CREATE TABLE IF NOT EXISTS T_CUSTOMER 
            (USER_ID TEXT NOT NULL PRIMARY KEY,
            NAME TEXT NOT NULL,
            NUM_COUPON INTEGER NOT NULL)";

        public const string T_MENU_ITEM = @"
            CREATE TABLE IF NOT EXISTS T_MENU_ITEM 
            (NAME TEXT NOT NULL PRIMARY KEY,
            PRICE INTEGER NOT NULL)";

        public const string T_RECIPE = @"
            CREATE TABLE IF NOT EXISTS T_RECIPE 
            (NAME TEXT NOT NULL PRIMARY KEY,
            MANUAL TEXT NOT NULL)";




    }
}

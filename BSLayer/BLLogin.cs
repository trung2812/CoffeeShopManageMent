﻿using CoffeeShopManageMent.Connects;
using CoffeeShopManageMent.UI_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManageMent.DataLayers
{
    public class BLLogin
    {
        string err;
        public BLLogin()
        {

        }
        public object CheckAccountVerification(string username, string password)
        {
            DBMain db = new DBMain();
            DataSet a = new DataSet();
            string error = string.Empty;
            string strSQL = $"SELECT dbo.CheckSAccountVerification('{username}','{password}')";
            CommandType ct = CommandType.Text;

            object result = db.MyExecuteScalar(strSQL, ct, ref error);

            if (result != null && result != DBNull.Value)
            {
                if (!(bool)result)
                {
                    strSQL = $"SELECT dbo.CheckMAccountVerification('{username}','{password}')";
                    result = db.MyExecuteScalar(strSQL, ct, ref error);

                    if (result != null && result != DBNull.Value)
                        if ((bool)result)
                        {
                            FMain.IsManager = true;
                            return (bool)result;
                        }
                    return (bool)result;
                }
                else
                {
                    return (bool)result;
                }          
            }

            if (!string.IsNullOrEmpty(error))
                throw new Exception(error);

            return null;
        }

        public bool ADD(string User, string Pass, string Name, string Addr)
        {
            DBMain db = new DBMain();
            if (string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Name))
                return false;
            if (string.IsNullOrEmpty(Addr))
                Addr = "";
            string sql = $"INSERT INTO NguoiDung (Ho_Ten,User_Name,Password,Dia_Chi,Admin) Values ('{Name}','{User}','{Pass}','{Addr}','False')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}

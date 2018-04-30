using System;
using System.Collections.Generic;
using System.Data;

namespace Software.Database.SQL
{
    public class SupplierDB
    {
        public static List<Model.Supplier> GetAllSuppliers()
        {
            List<Model.Supplier> suppliers = new List<Model.Supplier>();
            string query = "select * from supplier order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                suppliers.Add(RowToEntity(row));
            }
            return suppliers;
        }

        public static Model.Supplier RowToEntity(DataRow row)
        {
            Model.Supplier supplier = new Model.Supplier
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Contact_No = row["Contact_No"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString(),
                Date_Added = Convert.ToDateTime(row["Date_Added"]),
                Description = row["Description"].ToString()
            };
            return supplier;
        }

        public static void InsertSupplier(Model.Supplier supplier)
        {
            string query =
                "BEGIN " +
                "supplier_pkg.insert_supplier('" + supplier.Name + "', '" + supplier.Contact_No + "', '" + supplier.Email + "', '" + supplier.Address + "', '" + supplier.Date_Added.ToString(string.Format("dd/MMM/yyyy")) + "', '" + supplier.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateSupplier(Model.Supplier supplier)
        {
            string query =
                "BEGIN " +
                "supplier_pkg.update_supplier(" + supplier.Id + ", '" + supplier.Name + "', '" + supplier.Contact_No + "', '" + supplier.Email + "', '" + supplier.Address + "', '" + supplier.Date_Added.ToString(string.Format("dd/MMM/yyyy")) + "', '" + supplier.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteSupplier(int id)
        {
            string query =
                "BEGIN " +
                "supplier_pkg.delete_supplier(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}

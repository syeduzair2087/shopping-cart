using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Shopping_Cart
{
    public static class GeneralMethods
    {
        public static string cnstring = ConfigurationManager.ConnectionStrings["shoppingdb"].ConnectionString;
        public static SqlConnection con = new SqlConnection(cnstring);

        public static int GetCategory(string CategoryName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from dbo.get_category('" + CategoryName + "')", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            int Id = (int)dt.Rows[0][0];
            return Id;
        }

        public static bool CheckCategory(string CategoryName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select dbo.check_category('" + CategoryName + "')", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();

            int Check = (int)dt.Rows[0][0];
            if (Check == 1)
                return true;

            else
                return false;
        }

        public static int GetVendor(string VendorName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from dbo.get_vendor('" + VendorName + "')", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            int Id = (int)dt.Rows[0][0];
            return Id;
        }

        public static int GetUserCount()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select count(*) from [user]", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            int Count = (int)dt.Rows[0][0];
            return Count;
        }

        public static int GetCustomerCount()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select count(*) from customer", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            int Count = (int)dt.Rows[0][0];
            return Count;
        }

        public static bool CheckVendor(string VendorName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select dbo.check_vendor('" + VendorName + "')", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();

            int Check = (int)dt.Rows[0][0];
            if (Check == 1)
                return true;

            else
                return false;
        }

        public static DataTable GetUsers()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from get_users()", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetSalesOrders()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select soid, c.cname, cast(sotime as date) as \"date\" from sales_order so, customer c where so.cid = c.cid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetCustomers()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from get_customers()", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetCategories()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from category order by catname", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetVendors()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from vendor order by vname", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetProductsTable()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from product", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetProducts()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select pid as \"ID\", pname as \"Name\", vname as \"Vendor\", catname as \"Category\", profitrate as \"Profit (%)\", price as \"Price\", pprice as \"Selling Price\", quantity as \"Quantity\" from product p, vendor v, category c  where p.catid = c.catid and p.vid = v.vid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetProductsForReceiveOrder()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select pid as \"ID\", pname as \"Name\", vname as \"Vendor\", catname as \"Category\" from product p, vendor v, category c  where p.catid = c.catid and p.vid = v.vid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetProductsForSalesOrder()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select pid as \"ID\", pname as \"Name\", vname as \"Vendor\", catname as \"Category\", pprice as \"Price\", quantity as \"Quantity\" from product p, vendor v, category c  where p.catid = c.catid and p.vid = v.vid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetProductByID(int PID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select catname, vname, pname, profitrate, [description] from product p, vendor v, category c where pid = " + PID + " and p.catid = c.catid and p.vid = v.vid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static string GetProductNameByID(int PID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select pname from product where pid = " + PID , GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            string ProductName = (string)(dt.Rows[0][0]);
            return ProductName;
        }

        public static void AddUser(string UserName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.add_user", con);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void AddCustomer(string CustomerName, string CustomerContact, string CustomerAddress)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.add_customer", con);
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
            cmd.Parameters.AddWithValue("@CustomerContact", CustomerContact);
            cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void AddVendor(string VendorName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.add_vendor", con);
            cmd.Parameters.AddWithValue("@Vendor", VendorName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void AddCategory(string CategoryName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.add_category", con);
            cmd.Parameters.AddWithValue("@Category", CategoryName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void AddProduct(int CategoryID, int VendorID, string ProductName, int ProfitRate, string Description)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.add_product", con);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@VendorID", VendorID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@ProfitRate", ProfitRate);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdateCategory(int ID, string CategoryName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_category", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdateVendor(int ID, string VendorName)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_vendor", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@VendorName", VendorName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdateProduct(int PID, int VendorID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_product_vendor", con);
            cmd.Parameters.AddWithValue("@ID", PID);
            cmd.Parameters.AddWithValue("@VendorID", VendorID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdateProduct(int PID, int CategoryID, int VendorID, string ProductName, int ProfitRate, string Description)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_product", con);
            cmd.Parameters.AddWithValue("@ID", PID);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@VendorID", VendorID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@ProfitRate", ProfitRate);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void DeleteProduct(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            //SqlDataAdapter ada = new SqlDataAdapter("delete from product where pid = " + ID, GeneralMethods.con);
            //SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);
            SqlCommand cmd = new SqlCommand("delete from product where pid = " + ID, con);
            cmd.ExecuteNonQuery();
            GeneralMethods.con.Close();
            //return dt;
        }

        public static void DeleteCategory(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("delete from category where catid = " + ID, con);
            cmd.ExecuteNonQuery();
            GeneralMethods.con.Close();
        }

        public static void DeleteVendor(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("delete from vendor where vid = " + ID, con);
            cmd.ExecuteNonQuery();
            GeneralMethods.con.Close();
         }

        

        public static int GetPurchaseOrderID()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

           
                SqlDataAdapter ada = new SqlDataAdapter("select max(poid) from purchase_order", GeneralMethods.con);
                SqlCommandBuilder acb = new SqlCommandBuilder(ada);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                int NextID = (int)(dt.Rows[0][0]);
                return NextID;
        }

        public static int GetPreviousPurchaseOrderQuantity(int ProductID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select potquantity from purchase_order_transaction where pid = " + ProductID + " and poid = (select (MAX(poid)-1) from purchase_order)", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int NextID = (int)(dt.Rows[0][0]);
            return NextID;
        }

        public static int GetMaxVendorID()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select max(vid) from vendor", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int ProductID = (int)(dt.Rows[0][0]);
            return ProductID;
        }

        public static void CreatePurchaseOrder(int VendorID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_purchase_order", con);
            cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@VendorID", VendorID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void CreatePurchaseOrderTransaction(int POID, int PID, int Quantity)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_purchase_order_transaction", con);
            cmd.Parameters.AddWithValue("@PurchaseOrderID", POID);
            //cmd.Parameters.AddWithValue("@VendorID", VID);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static int GetReceiveOrderID()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select max(roid) from receive_order", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int NextID = (int)(dt.Rows[0][0]);
            return NextID;
        }

        public static int GetSalesOrderID()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select max(soid) from sales_order", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int NextID = (int)(dt.Rows[0][0]);
            return NextID;
        }

        public static int GetProfitRate(int ProductID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select profitrate from product where pid = " + ProductID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int ProfitRate = Convert.ToInt32(dt.Rows[0][0]);
            return ProfitRate;
        }

        public static int GetQuantity(int ProductID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select quantity from product where pid = " + ProductID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int Quantity = Convert.ToInt32(dt.Rows[0][0]);
            return Quantity;
        }

        public static int GetProductVendor(int ProductID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select vid from product where pid = " + ProductID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int VendorID = Convert.ToInt32(dt.Rows[0][0]);
            return VendorID;
        }

        public static void CreateReceiveOrderTransaction(int ROID, int UID, int PID, int Quantity, float Price)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_receive_order_transaction", con);
            cmd.Parameters.AddWithValue("@ReceiveOrderID", ROID);
            //cmd.Parameters.AddWithValue("@UserID", UID);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void CreateSalesOrderTransaction(int SOID, int PID, int Quantity, float Price)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_sales_order_transaction", con);
            cmd.Parameters.AddWithValue("@SalesOrderID", SOID);
            //cmd.Parameters.AddWithValue("@UserID", UID);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdatePurchaseOrderTransaction(int POTID, int POID, int VID, int PID, int Quantity)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_purchase_order_transaction", con);
            cmd.Parameters.AddWithValue("@PurchaseOrderTransactionID", POTID);
            cmd.Parameters.AddWithValue("@PurchaseOrderID", POID);
            cmd.Parameters.AddWithValue("@VendorID", VID);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdatePurchaseOrderTransactionQuantity(int POTID, int Quantity)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_purchase_order_transaction_quantity", con);
            cmd.Parameters.AddWithValue("@PurchaseOrderTransactionID", POTID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        //public static bool CreateNewPurchaseOrder(int VID)
        //{
        //    if (!(GeneralMethods.con.State == ConnectionState.Open))
        //        GeneralMethods.con.Open();


        //    SqlDataAdapter ada = new SqlDataAdapter("select count(*) from purchase_order where vid = " + VID, GeneralMethods.con);
        //    SqlCommandBuilder acb = new SqlCommandBuilder(ada);
        //    DataTable dt = new DataTable();
        //    ada.Fill(dt);

        //    SqlDataAdapter bda = new SqlDataAdapter("select count(*) from receive_order" , GeneralMethods.con);
        //    SqlCommandBuilder bcb = new SqlCommandBuilder(bda);
        //    DataTable bdt = new DataTable();
        //    bda.Fill(bdt);

        //    int CountPurchaseOrder = (int)(dt.Rows[0][0]);
        //    int CountReceiveOrder = (int)(bdt.Rows[0][0]);

        //    if (CountPurchaseOrder == CountReceiveOrder)
        //        return true;

        //    else
        //        return false;
            
        //}

        public static bool CreateNewReceieveOrder()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select count(*) from purchase_order", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            SqlDataAdapter bda = new SqlDataAdapter("select count(*) from receive_order", GeneralMethods.con);
            SqlCommandBuilder bcb = new SqlCommandBuilder(bda);
            DataTable bdt = new DataTable();
            bda.Fill(bdt);

            int CountPurchaseOrder = (int)(dt.Rows[0][0]);
            int CountReceiveOrder = (int)(bdt.Rows[0][0]);

            if (CountReceiveOrder == (CountPurchaseOrder -1))
                return true;

            else
                return false;

        }

        public static DataTable GetPurchaseOrders()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select poid , cast(potime as date) as \"date\" from purchase_order", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetPurchaseOrderTransactionTable(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select * from purchase_order_transaction where poid = " + ID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetReceiveOrders()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select r.roid as \"ID\", u.uname as \"User Name\", cast(r.rotime as date) as \"Date\"  from receive_order r, [user] u where u.uid = r.uid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetReceiveOrderTransactions(int OrderID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select r.rotid as \"ID\", p.pname as \"Product\", r.rotquantity as \"Quantity\", r.rottotalamount as \"Total Price\" from receive_order_transaction r, product p where p.pid = r.pid and r.roid = " + OrderID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }


        public static DataTable GetPurchaseOrderTransaction(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select potid as \"Transaction ID\", pot.poid as \"Order ID\", vname as \"Vendor\", pname as \"Product\", potquantity as \"Quantity\" from product p, vendor v, purchase_order_transaction pot, purchase_order po where po.vid = v.vid and pot.pid = p.pid and pot.poid = po.poid and pot.poid = " + ID, GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetSalesOrderTransaction(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select tid as \"Transaction ID\", soid as \"Sales Order ID\", p.pname as \"Product\", sotquantity as \"Quantity\", sottotalamount as \"Amount\" from sales_order_transaction sot, product p where sot.soid = " + ID + " and p.pid = sot.pid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static DataTable GetReceiveOrderTransaction(int ID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlDataAdapter ada = new SqlDataAdapter("select rotid as \"Transaction ID\", roid as \"Order ID\", p.pname as \"Product\", rotquantity as \"Quantity\", rottotalamount as \"Amount\" from receive_order_transaction rot, product p where rot.roid = " + ID + " and p.pid = rot.pid", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GeneralMethods.con.Close();
            return dt;
        }

        public static void UpdateProductQuantityAndPrice(int PID, int Quantity, float Price, float SellingPrice)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_product_price_and_quantity", con);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void UpdateProductQuantityOnSale(int PID, int Quantity)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.update_product_price_on_sale", con);
            cmd.Parameters.AddWithValue("@ProductID", PID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void CreateReceiveOrder(int UID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_receive_order", con);
            cmd.Parameters.AddWithValue("@UserID", UID);
            cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void CreateSalesOrder(int CID)
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();

            SqlCommand cmd = new SqlCommand("dbo.create_sales_order", con);
            cmd.Parameters.AddWithValue("@CustomerID", CID);
            cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteReader();
            GeneralMethods.con.Close();
        }

        public static void CreateReceiveOrderMethod()
        {
            if (GeneralMethods.CreateNewReceieveOrder())
            {
 
            }
        }

        //public static void CreatePurchaseOrderAfterReceive(int VendorID, int ProductID, int Quantity)
        //{
        //    if (GeneralMethods.CreateNewPurchaseOrder())
        //    {

        //        DataTable Products = new DataTable();
        //        Products = GeneralMethods.GetProductsTable();
        //        GeneralMethods.CreatePurchaseOrder();
        //        int ID = GeneralMethods.GetPurchaseOrderID();
        //        GeneralMethods.CreatePurchaseOrderTransaction(ID, VendorID, ProductID, Quantity);
                
        //    }

        //    else if (!(GeneralMethods.CreateNewPurchaseOrder()))
        //    {
        //        int ID = GeneralMethods.GetPurchaseOrderID();
        //        DataTable Products = new DataTable();
        //        DataTable PurchaseOrders = new DataTable();
        //        DataTable Transactions = new DataTable();

        //        Products = GeneralMethods.GetProductsTable();
        //        PurchaseOrders = GeneralMethods.GetPurchaseOrders();
        //        Transactions = GeneralMethods.GetPurchaseOrderTransactionTable(ID);

        //        GeneralMethods.CreatePurchaseOrderTransaction(ID, VendorID, ProductID, Quantity);
        //        //GeneralMethods.CreatePurchaseOrder();
                

                
        //    }
        //}


        public static void CreatePurchaseOrderMethod()
          {
            //if (GeneralMethods.CreateNewPurchaseOrder())
            //{

                DataTable Products = new DataTable();
                

                
                Products = GeneralMethods.GetProductsTable();
                
                //GeneralMethods.CreatePurchaseOrder();
                //int ID = GeneralMethods.GetPurchaseOrderID();

            int j = GetMaxVendorID();

            if (j < 1)
                return;

            for(int i = 1; i <= j; i++)
            {
                bool CreateOrder = true;

                foreach (DataRow row in Products.Rows)
                {
                    

                    if ((Convert.ToInt32(row["quantity"])) <= 5 && (Convert.ToInt32(row["vid"])) == i)
                    {
                        //int ID = 0;

                        if (CreateOrder)
                        {
                            GeneralMethods.CreatePurchaseOrder(i);
                            CreateOrder = false;
                        }

                        int ID = GetPurchaseOrderID();
                        int PID = (Convert.ToInt32(row["pid"]));
                        int VID = (Convert.ToInt32(row["vid"]));
                        int Quantity = 10;
                        GeneralMethods.CreatePurchaseOrderTransaction(ID, PID, Quantity);
                    }
                }
            }
            //}

            //else if (!(GeneralMethods.CreateNewPurchaseOrder()))
            //{
            //    int ID = GeneralMethods.GetPurchaseOrderID();
            //    DataTable Products = new DataTable();
            //    DataTable PurchaseOrders = new DataTable();
            //    DataTable Transactions = new DataTable();

            //    Products = GeneralMethods.GetProductsTable();
            //    PurchaseOrders = GeneralMethods.GetPurchaseOrders();
            //    Transactions = GeneralMethods.GetPurchaseOrderTransactionTable(ID);

            //    //GeneralMethods.CreatePurchaseOrder();


            //    foreach (DataRow prow in Products.Rows)
            //    {
            //        if (((int)(prow["quantity"])) <= 5)
            //        {
            //            bool NotExists = true;
            //            int tquantity = 0;
            //            int tid = 0;

            //            foreach (DataRow trow in Transactions.Rows)
            //            {
            //                if ((int)prow["pid"] == (int)trow["pid"])
            //                {
            //                    NotExists = false;
            //                    tquantity = ((int)(trow["potquantity"]));
            //                    tid = ((int)trow["potid"]);
            //                    break;
            //                }
            //            }

            //            if (NotExists)
            //            {
            //                int PID = ((int)(prow["pid"]));
            //                int VID = ((int)(prow["vid"]));
            //                int Quantity = 10;
            //                GeneralMethods.CreatePurchaseOrderTransaction(ID, VID, PID, Quantity);
            //            }

            //            //else if (!(NotExists))
            //            //{
            //            //    if(tquantity < 10)
            //            //    {
            //            //        int PID = ((int)(prow["pid"]));
            //            //        int VID = ((int)(prow["vid"]));
            //            //        UpdatePurchaseOrderTransaction(tid, GetPurchaseOrderID(), VID, PID, 10);
            //            //    }
            //            //}
            //        }
            //    }
            //}
        }

        public static int GetProductID()
        {
            if (!(GeneralMethods.con.State == ConnectionState.Open))
                GeneralMethods.con.Open();


            SqlDataAdapter ada = new SqlDataAdapter("select max(pid) from product", GeneralMethods.con);
            SqlCommandBuilder acb = new SqlCommandBuilder(ada);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int NextID = (int)(dt.Rows[0][0]);
            return NextID;
        }
    }
}

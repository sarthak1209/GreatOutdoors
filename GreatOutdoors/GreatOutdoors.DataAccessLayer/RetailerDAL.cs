using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoors.Entities;


namespace GreatOutdoors.DataAccessLayer
{
    public class RetailerDAL
    {
        public static List<Retailer> retailerList = new List<Retailer>();

        public bool AddRetailerDAL(Retailer newRetailer)
        {
            bool retailerAdded = false;
            try
            {
                retailerList.Add(newRetailer);
                retailerAdded = true;
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return retailerAdded;

        }

        public List<Retailer> GetAllRetailersDAL()
        {
            return retailerList;
        }

        public Retailer SearchRetailerDAL(int searchGuestID)
        {
            Retailer searchRetailer = null;
            try
            {
                foreach (Retailer item in retailerList)
                {
                    if (item.RetailerID == searchGuestID)
                    {
                        searchRetailer = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return searchRetailer;
        }

        public List<Retailer> GetRetailerByNameDAL(string guestName)
        {
            List<Retailer> searchRetailer = new List<Retailer>();
            try
            {
                foreach (Retailer item in retailerList)
                {
                    if (item.RetailerName == guestName)
                    {
                        searchRetailer.Add(item);
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return searchRetailer;
        }


        public bool UpdateRetailerDAL(Retailer updateRetailer)
        {
            bool retailerUpdated = false;
            try
            {
                for (int i = 0; i < retailerList.Count; i++)
                {
                    if (retailerList[i].RetailerID == updateRetailer.RetailerID)
                    {
                        updateRetailer.RetailerName = retailerList[i].RetailerName;
                        updateRetailer.RetailerContactNumber = retailerList[i].RetailerContactNumber;
                        retailerUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return retailerUpdated;

        }
        public bool DeleteRetailerDAL(int deleteRetailerID)
        {
            bool retailerDeleted = false;
            try
            {
                Retailer deleteRetailer = null;
                foreach (Retailer item in retailerList)
                {
                    if (item.RetailerID == deleteRetailerID)
                    {
                        deleteRetailer = item;
                    }
                }

                if (deleteRetailer != null)
                {
                    retailerList.Remove(deleteRetailer);
                    retailerDeleted = true;
                }
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return retailerDeleted;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoors.Entities;


namespace GreatOutdoors.DataAccessLayer
{
    class CategoryDAL
    {

        public static List<Category> categoryList = new List<Category>();

        public bool AddCategoryDAL(Category newCategory)
        {
            bool categoryAdded = false;
            try
            {
                categoryList.Add(newCategory);
                categoryAdded = true;
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return categoryAdded;

        }


        public List<Category> GetAllCategorysDAL()
        {
            return categoryList;
        }

        public Category SearchCategoryDAL(int searchCategoryID)
        {
            Category searchCategory = null;
            try
            {
                foreach (Guest item in guestList)
                {
                    if (item.GuestID == searchGuestID)
                    {
                        searchGuest = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return searchGuest;
        }
    }
}

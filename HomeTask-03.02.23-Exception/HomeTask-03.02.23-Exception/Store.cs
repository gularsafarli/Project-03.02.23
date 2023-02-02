using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_03._02._23_Exception
{
    class Store
    {
        public Product[] Products;

        public void AddProduct(Product pr)
        {
            if (!HasProductByNo(pr.No))
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = pr;
            }
            else
            {
                throw new DuplicatedItemException();
            }
        }
        public bool HasProductByNo(int no)
        {
            for (int i = 0; i <Products.Length; i++)
            {
                if (Products[i].No==no)
                {
                    return true;
                }
            }
            return false;
        }
        public Product GetProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (HasProductByNo(no))
                {
                    return Products[i];
                }
            }
            throw new ProductNotFoundException();
        }     
    }
}

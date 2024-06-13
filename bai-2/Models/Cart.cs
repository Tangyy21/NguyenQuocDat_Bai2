using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai_2.Models
{
    //Lop bieu dien phan tu gio hang
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    //Lop bieu dien gio hang
    public class Cart
    {
        private List<CartItem> _items;
        public Cart()
        {
            _items = new List<CartItem>();
        }
        public List<CartItem> Items { get { return _items; } }
        //cac phuong tien xu ly gio hang
        public void Add(Product p, int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == p.Id);
            if (item == null)//neu chua co
            {
                _items.Add(new CartItem { Product = p, Quantity = qty });
            }
            else// co roi thi tang len
            {
                item.Quantity += 1;
            }
        }
        public void Update(int productId, int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == productId);
            if (item != null)
            {
                if (qty > 0)
                {
                    item.Quantity = qty;
                }
                else
                {
                    _items.Remove(item);
                }
            }
        }
        public void Delete(int productId)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == productId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
        //phuong thuc tong thanh tien
        public double Total
        {
            get
            {
                double total = _items.Sum(x => x.Quantity * x.Product.Price);
                return total;
            }
        }
        //tinh tong so luong thanh pham cua gio
        public double Quantity
        {
            get
            {
                double total = _items.Sum(x => x.Quantity);
                return total;
            }
        }
    }
}

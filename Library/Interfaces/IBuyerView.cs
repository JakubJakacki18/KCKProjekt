﻿using Library.Models;

namespace Library.Interfaces
{
    public interface IBuyerView
    {
        bool ExitApp();
        void ShowAllProducts(List<ProductModel> products);
        public void ShowInterface();
        public int ShowMenu();
        void ShowPaymentMethod();
        void ShowUserCart();
    }
}

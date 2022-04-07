using System;
using System.Collections.Generic;
using System.Text;

    public class Product
    {
        private string _productName;
        private string _serialNumber;
        private DateTime _purchaseDate;
        private double _cost;
        
        // Implement 4-Argument Constructor
        
        // Implement Properties
        public Product(string _productName,string _serialNumber,DateTime _purchaseDate,double _purchasecost){
            this._productName = _productName;
            this._serialNumber = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._cost = _purchasecost;
        }
        

        public string ProductName{
            set{this._productName = value;}
            get{return this._productName;}
        }
        public string SerialNumber{
            
            set{this._serialNumber = value;}
            get{return this._serialNumber;}
        }
        
        public DateTime PurchaseDate{
            
            set{this._purchaseDate = value;}
            get{return this._purchaseDate;}
        }
        public double PurchaseCost{
            
            set{this._cost = value;}
            get{return this._cost;}
        }
       
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate), PurchaseCost);
        }
    }


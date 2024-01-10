// See https://aka.ms/new-console-template for more information
using Assignment;

Console.WriteLine("Hello, World!");

List<Product> products = new List<Product>()
{
    new Product(){PName="Oil",PPrice=700.56,PBrand="XYZ",ManufacturingDate=new DateTime(day:12,month:11,year:2009),ExpiryDate=new DateTime(day:12,month:01,year:2010)},
    new Product(){PName="Shampoo",PPrice=900.56,PBrand="ABC",ManufacturingDate=new DateTime(day:12,month:11,year:2019),ExpiryDate=new DateTime(day:12,month:11,year:2020)},
    new Product(){PName="Biscuit",PPrice=80.56,PBrand="XYZ",ManufacturingDate=new DateTime(day:12,month:11,year:2015),ExpiryDate=new DateTime(day:12,month:11,year:2016)},
    new Product(){PName="Choco",PPrice=450.56,PBrand="ABC",ManufacturingDate=new DateTime(day:12,month:11,year:2022),ExpiryDate=new DateTime(day:12,month:11,year:2023)},
    new Product(){PName="Coco",PPrice=100.56,PBrand="XYZ",ManufacturingDate=new DateTime(day:12,month:11,year:2014),ExpiryDate=new DateTime(day:12,month:11,year:2016)},
};
Console.WriteLine("PNAME\t\t PPRICE \t PBRAND \t MANUFACTURINGDATE \t\t EXPIRYDATE");
foreach (Product product in products)
{
    Console.Write(product.PName+"\t \t");
    Console.Write(product.PPrice+"\t \t");
    Console.Write(product.PBrand+"\t \t");
    Console.Write(product.ManufacturingDate+"\t \t");
    Console.Write(product.ExpiryDate + "\t \t");
    Console.WriteLine("\n");
}
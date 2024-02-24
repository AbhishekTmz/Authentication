using AuthLib;

namespace AuthTest;

public class UnitTest1
{
    [Fact]
    public void ProductTest()
    {
var product = new Product(){
  Id = 1,
  Price = 100,
  Name = "Mobile",
  Description = "Samsung mobile new S24 ultra"
};
Assert.Equal(1, product.Id);
Assert.Equal(100, product.Price);
Assert.Equal("Mobile", product.Name);
Assert.Equal("Samsung mobile new S24 ultra", product.Description);
  }
  [Fact]
      public void ProductTest2()
    {
var product = new Product(){
  Id = 2,
  Price = 400,
  Name = "Glass",
  Description = "Glass for window"
};
Assert.Equal(2, product.Id);
Assert.Equal(400, product.Price);
Assert.Equal("Glass", product.Name);
Assert.Equal("Glass for window", product.Description);
  }
    [Fact]
      public void ProductTest3()
    {
var product = new Product(){
  Id = 3,
  Price = 700,
  Name = "Laptop",
  Description = "Mac book pro"
};
Assert.Equal(3, product.Id);
Assert.Equal(700, product.Price);
Assert.Equal("Laptop", product.Name);
Assert.Equal("Mac book pro", product.Description);
  }
    [Fact]
      public void ProductTest4()
    {
var product = new Product(){
  Id = 4,
  Price = 600,
  Name = "Jacket",
  Description = "winter jacket"
};
Assert.Equal(4, product.Id);
Assert.Equal(600, product.Price);
Assert.Equal("Jacket", product.Name);
Assert.Equal("winter jacket", product.Description);
  }



}
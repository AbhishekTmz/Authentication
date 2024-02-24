using AuthLib;

namespace AuthTest;

public class UnitTest3
{
    [Fact]
    public void ShoppingCartTest()
    {
var shoppingCart = new ShoppingCartModel(){
  Id = 1,
  User = "Abhishek",
};
Assert.Equal(1, shoppingCart.Id);
Assert.Equal("Abhishek", shoppingCart.User);
  }
  [Fact]
      public void ShoppingCartTest2()
    {
var shoppingCart = new ShoppingCartModel(){
  Id = 2,
  User = "Hui",
};
Assert.Equal(2, shoppingCart.Id);
Assert.Equal("Hui", shoppingCart.User);
  }
    [Fact]
      public void ShoppingCartTest3()
    {
var shoppingCart = new ShoppingCartModel(){
  Id = 3,
 User = "Sanju"
};
Assert.Equal(3, shoppingCart.Id);
Assert.Equal("Sanju", shoppingCart.User);
  }
    [Fact]
      public void ShoppingCartTest4()
    {
var shoppingCart = new ShoppingCartModel(){
  Id = 4,
  User = "Tikam"
};
Assert.Equal(4, shoppingCart.Id);
Assert.Equal("Tikam", shoppingCart.User);
  }



}
using AuthLib;

namespace AuthTest;

public class UnitTest2
{
    [Fact]
    public void CategoryTest()
    {
var category = new Category(){
  Id = 1,
  Description = "Samsung mobile new S24 ultra"
};
Assert.Equal(1, category.Id);
Assert.Equal("Samsung mobile new S24 ultra", category.Description);
  }
  [Fact]
      public void CategoryTest2()
    {
var category = new Category(){
  Id = 2,
  Description = "Glass for window"
};
Assert.Equal(2, category.Id);
Assert.Equal("Glass for window", category.Description);
  }
    [Fact]
      public void CategoryTest3()
    {
var category = new Category(){
  Id = 3,
  Description = "Mac book pro"
};
Assert.Equal(3, category.Id);
Assert.Equal("Mac book pro", category.Description);
  }
    [Fact]
      public void CategoryTest4()
    {
var category = new Category(){
  Id = 4,
  Description = "winter jacket"
};
Assert.Equal(4, category.Id);
Assert.Equal("winter jacket", category.Description);
  }



}
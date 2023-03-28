namespace UniversityWebApi.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public List<Tutorial> GetTutorials() {}

    public Category GetById(int id) {}

    public List<Category> GetAll() {}

    public void Create(Category category) {}

    public void Update(int id, Category category) {}

    public void Delete(int id) {}
}
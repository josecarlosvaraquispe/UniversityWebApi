namespace UniversityWebApi.Models;

public class Tutorial
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }

    public Tutorial GetById(int id) {}

    public List<Tutorial> GetAll() {}

    public void Create(Tutorial tutorial) {}

    public void Update(int id, Tutorial tutorial) {}

    public void Delete(int id) {}
}
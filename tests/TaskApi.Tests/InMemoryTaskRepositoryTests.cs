using TaskApi.Repositories;
using TaskApi.Models;
using FluentAssertions;
namespace TaskApi.Tests.Repositories;
public class InMemoryTaskRepositoryTests {
//     private readonly InMemoryTaskRepository _repo;
//     public InMemoryTaskRepositoryTests(){
//         _repo = new();
//     }
    
//     [Fact]
//     public void Add_TareaValida_AsignaIdYRetornaTarea(){
//         //Arrange        
//         var tarea = new TaskItem {
//             Title = "Comprar Guitarra",
//             Description= "Comprar Guitarra para ser Feliz"
//         };
//         //Act
//         var resultado = _repo.Add(tarea);
//         //Arrange
//         resultado.Id.Should().BeGreaterThan(0);
//         resultado.Title.Should().Be("Comprar Guitarra");
//     }

//     [Fact]
//     public void Add_DosTarea_AsignaIdsSecuenciales() {

//         var tarea1 = new TaskItem{
//             Title = "Comprar Guitarra",
//             Description= "Comprar Guitarra para ser Feliz"
//         };

//         var tarea2 = new TaskItem{
//             Title = "Comprar Laptop",
//             Description= "Comprar Laptop"
//         };

//         var r1 = _repo.Add(tarea1);
//         var r2 = _repo.Add(tarea2);

//         r2.Id.Should().Be(r1.Id + 1);
//     }

//     [Fact]
//     public void GetAll_RepositorioVacio_RetornaColeccionVacia()
//     {
        


//         var resultado = _repo.GetAll();

//         resultado.Should().BeEmpty();
//     }

//     [Fact]
// public void GetAll_ConDosTareas_RetornaDosTareas()
// {
//     // Arrange
//     var tarea1 = new TaskItem
//     {
//         Title = "Comprar Guitarra",
//         Description = "Comprar Guitarra para ser feliz"
//     };

//     var tarea2 = new TaskItem
//     {
//         Title = "Comprar Laptop",
//         Description = "Comprar Laptop"
//     };

//     _repo.Add(tarea1);
//     _repo.Add(tarea2);

//     // Act
//     var resultado = _repo.GetAll();

//     // Assert
//     resultado.Should().HaveCount(2);
//     resultado.Should().Contain(t => t.Title == "Comprar Guitarra");
//     resultado.Should().Contain(t => t.Title == "Comprar Laptop");
// }

//     [Fact]
//     public void GetById_TareaExiste_RetornaTarea()
//     {
//         var tarea1 = new TaskItem
//         {
//             Title = "Comprar Guitarra",
//             Description = "Comprar Guitarra para ser feliz"
//         };

//         var tareaAgregada = _repo.Add(tarea1);

//         var resultado = _repo.GetById(tareaAgregada.Id);

//         resultado.Should().NotBeNull();
//         resultado!.Title.Should().Be("Comprar Guitarra");
//     }

//     [Fact]
//     public void GetById_IdNoExiste_RetornaNull()
//     {
//         var resultado = _repo.GetById(1000);

//         resultado.Should().BeNull();
//     }

//     [Fact]
//     public void Uptade_TareaExiste_ActualizaPropiedades()
//     {
//         var tareaOriginal = _repo.Add(new TaskItem{Title="Tarea 1", Description="Tarea 1"});
//         var cambiosTarea = new TaskItem{Title = "Actualizada", Description = "Tarea 1 actualizada"};

//         var resultado = _repo.Update(tareaOriginal.Id, cambiosTarea);

//         resultado.Should().NotBeNull();
//         resultado.Title.Should().Be("Actualizada");
//     }

//     [Fact]
//     public void Update_IdNoExistente_RetornaNull()
//     {
//         var resultado =_repo.Update(1000, new TaskItem{Title="XXX"});

//         resultado.Should().BeNull();
//     }

//     [Fact]
//     public void Delete_TareaExiste_RetornaTrue()
//     {
//         var tareaAgregada = _repo.Add(new TaskItem{Title="Tarea a eliminar"});

//         var resultado = _repo.Delete(tareaAgregada.Id);

//         resultado.Should().BeTrue();
//         _repo.GetById(tareaAgregada.Id).Should().BeNull();
//     }

//     [Fact]
//     public void Delete_TareaNoExiste_RetornaFalse()
//     {
//          var resultado =_repo.Delete(1000);

//         resultado.Should().BeFalse();
//     }

}
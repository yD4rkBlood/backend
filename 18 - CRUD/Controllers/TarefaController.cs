using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _18___CRUD.Models;

namespace _18___CRUD.Controllers
{

    //Criando a classe TarefaController e herdando seus métodos de Controller
    public class TarefaController : Controller
    {
        //Criando um objeto _tarefas que armazenará uma lista de tarefas
        private static List<Tarefa> _tarefa = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefa);
        }

        //Criando o método GET para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            novaTarefa.Id = _tarefa.Count + 1;
            //Adicionando tarefas a lista
            _tarefa.Add(novaTarefa);
            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            // Estou buscando na minha lista a tarefa que desejo alterar
            Tarefa tarefaBD = _tarefa.FirstOrDefault(t => t.Id == Id);
            // Verificando se encontrou a tarefa, se ela não é null
            if (tarefaBD == null)
                return NotFound();
            // Enviando para a View a tarefa encontrada que queremos alterar
            return View(tarefaBD);
        }

        [HttpPost]

        public IActionResult Editar(Tarefa tarefaEditando)
        {
            Tarefa tarefaBD = _tarefa.Find(t => t.Id == tarefaEditando.Id);
            if (tarefaBD == null)
            return NotFound();

            tarefaBD.Descricao = tarefaEditando.Descricao;
            tarefaBD.Concluida = tarefaEditando.Concluida;

            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int Id)
        {
            Tarefa tarefaBD = _tarefa.FirstOrDefault(t => t.Id == Id);

            if (tarefaBD == null)
                return NotFound();
                
            return View(tarefaBD);
        }

        [HttpPost]


        public IActionResult Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaBD = _tarefa.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaBD == null)
            return NotFound();

            _tarefa.Remove(tarefaBD);

            return RedirectToAction("Index");
        }
    }
}
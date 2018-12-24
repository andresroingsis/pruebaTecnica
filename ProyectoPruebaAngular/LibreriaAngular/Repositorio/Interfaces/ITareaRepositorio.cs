using LibreriaAngular.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAngular.Repositorio.Interfaces
{
    public interface ITareaRepositorio
    {
        Task<List<Tarea>> ObtenerListadodeTareas(int intTodas, string strTodasPorEstado);

        Task<List<Tarea>> ObtenerListadodeTareas();

        Task<Tarea> AgregarTarea(Tarea tareaAInsertar);

        Task<Tarea> ActualizarTarea(Tarea tareaAInsertar);

        Task BorrarTarea(string strTareaId);

        Task<Tarea> ObtenerTareaPorId(Guid guTareaId);
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Pages
{
    public class CounterBase:ComponentBase
    {
         [Inject] protected ServicioSingleton Singleton { get; set; }
        [Inject] protected ServicioTransient Transient { get; set; }

        [Inject] protected IJSRuntime JS { get; set; }

        [CascadingParameter] protected string Color { get; set; }

        protected int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async  void IncrementCount()
        {
           

            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount; 
            currentCountStatic++;
            await JS.InvokeVoidAsync("PruebaPuntoNetEstatico");
        }

        [JSInvokable]
        public static Task ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
        protected async void IncrementCountJS()
        {
            // hay que pasar una referencia de un objeto que se pueda usar desde javescrpit
            await JS.InvokeVoidAsync("PruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }
    }
}

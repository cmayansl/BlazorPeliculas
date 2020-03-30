function PruebaPuntoNetEstatico() {
    
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log(" Conteo desde javascript " + resultado);
        })
}
function PruebaPuntoNetInstancia(donetHelpers) {
    donetHelpers.invokeMethodAsync("IncrementCount")
}
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json;
using Newtonsoft.Json;

namespace PeliculasAPI.Utilidades
{
    public class TypeBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName).FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                bindingContext.Result = ModelBindingResult.Success(null);
                return Task.CompletedTask;
            }
            try
            {
                var result = JsonConvert.DeserializeObject(value, bindingContext.ModelType);
                bindingContext.Result = ModelBindingResult.Success(result);
            }
            catch (Exception ex)
            {
                bindingContext.ModelState.AddModelError(modelName, $"Error al deserializar: {ex.Message}");
            }

            return Task.CompletedTask;
        }
    }
}

using AngularCoreGym.ViewModels;

namespace AngularCoreGym.Interface
{
    public interface IGenerateRecepit
    {
        GenerateRecepitViewModel Generate(int paymentId);
    }
}
using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Entities.EncryptFileBindingModel;

namespace SaveZone.Services.EncryptFileServices
{
    public interface IEncryptorFileService
    {
        void AESEncryptFile(string filePath, EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel);
    }
}

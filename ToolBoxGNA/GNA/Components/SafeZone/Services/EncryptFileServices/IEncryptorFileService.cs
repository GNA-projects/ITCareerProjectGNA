using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Entities.EncryptFileBindingModel;

namespace SaveZone.Services.EncryptFileServices
{
    /* interface used by EncryptorFileService for implementing methods for encrypting*/
    public interface IEncryptorFileService
    {
        void AESEncryptFile(string filePath, EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel);
    }
}

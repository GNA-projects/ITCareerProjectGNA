using SaveZone.Entities.CheckPasswordBindingModel;
using SaveZone.Entities.DecryptFileBindingModel;

namespace SaveZone.Services.DecryptFileService
{
    /* interface used by DecryptorFileService for implementing methods for decrypting*/
    public interface IDecryptorFileService
    {
        void AESDecryptFile(string fileName, string filePath, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel passwordBindingModel);
    }
}

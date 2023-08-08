using EmployeeOnboarding.Data;
using EmployeeOnboarding.Models;
using EmployeeOnboarding.ViewModels;
using OnboardingWebsite.Models;

namespace EmployeeOnboarding.Services
{
    public class AdditionalDetails
    {
        private ApplicationDbContext _context;
        public AdditionalDetails(ApplicationDbContext context)

        {

            _context = context;

        }
        private string SaveCertificateFile(IFormFile certificateFile, string Id, string fileName)
        {
            if (certificateFile == null)
            {
                return null;
            }
            var empFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Certificates", Id);
            if (!Directory.Exists(empFolderPath))
            {
                Directory.CreateDirectory(empFolderPath);
            }
            var filePath = Path.Combine(empFolderPath, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                certificateFile.CopyTo(fileStream);
            }
            return filePath; // Return the file path
        }
    


public void AddAdditional(int Id, AdditionalVM additional)
{
    var existingAdditional = _context.EmployeeAdditionalInfo.FirstOrDefault(e => e.EmpGen_Id == Id);

    if (existingAdditional != null)
    {
                //Update existing record

                existingAdditional.Disability = additional.Disability;
                existingAdditional.Disablility_type = additional.Disablility_type;
                existingAdditional.Covid_VaccSts = additional.Covid_VaccSts;
                existingAdditional.Vacc_Certificate = SaveCertificateFile(additional.Vacc_Certificate, Id.ToString(), "Vacc_Certificate.pdf");
                existingAdditional.Date_Modified = DateTime.UtcNow;
                existingAdditional.Modified_by = Id.ToString();
                existingAdditional.Status = "A";
    }
    else
    {
        //Add new record

        var certificateFileName = "Vacc_Certificate.pdf";
        var _additional = new EmployeeAdditionalInfo()
        {
            EmpGen_Id = Id,
            Disability = additional.Disability,
            Disablility_type = additional.Disablility_type,
            Covid_VaccSts = additional.Covid_VaccSts,
            Vacc_Certificate = SaveCertificateFile(additional.Vacc_Certificate,Id.ToString(), certificateFileName),
            Date_Created = DateTime.UtcNow,
            Date_Modified = DateTime.UtcNow,
            Created_by = Id.ToString(),
            Modified_by = Id.ToString(),
            Status = "A"
        };

        _context.EmployeeAdditionalInfo.Add(_additional);
    }

    _context.SaveChanges();
}




//get method

        public getAdditionalVM GetAdditional(int Id)
        {
            var _additional = _context.EmployeeAdditionalInfo.Where(n => n.EmpGen_Id == Id).Select(additional => new getAdditionalVM()
            {
                Disability = additional.Disability,
                Disablility_type = additional.Disablility_type,
                Covid_VaccSts = additional.Covid_VaccSts,
                Vacc_Certificate = GetFile(additional.Vacc_Certificate)

            }).FirstOrDefault();
            return _additional;
        }

        public static byte[] GetFile(string filepath)
        {
            if (System.IO.File.Exists(filepath))
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(filepath);
                byte[] file = new byte[fs.Length];
                int br = fs.Read(file, 0, file.Length);
                if (br != fs.Length)
                {
                    throw new IOException("Invalid path");
                }
                return file;
            }
            return null;
        }

    }

}


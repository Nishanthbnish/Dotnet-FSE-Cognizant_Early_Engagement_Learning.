using System;

namespace GenericMedicine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program objMainProgram = new Program();
            Medicine medicine = new Medicine();

            Console.Write("**********************************");
            Console.WriteLine();
            Console.Write("Generic medicine application");
            Console.WriteLine();
            Console.Write("**********************************");
            Console.WriteLine();
            try
            {
                #region Create medicine detail
                string medicineName = string.Empty;
                string genericMedicineName = string.Empty;
                string medicineComposition = string.Empty;
                double pricePerStrip = 0;
                DateTime expiryDate;

                Console.WriteLine("Dear admin, please enter the medicine name you want to provide the generic medicine detail");
                Console.WriteLine();
                Console.WriteLine("1. Dolo 650");
                Console.WriteLine("2. Montair LC");
                Console.WriteLine("3. Remilyn D");
                Console.WriteLine();

                medicineName = Console.ReadLine();
                Console.WriteLine("Please provide the corresponding Generic medicine name");
                genericMedicineName = Console.ReadLine();
                Console.WriteLine("Please provide the composition (Chemical names separated by comma)");
                medicineComposition = Console.ReadLine();
                Console.WriteLine("Please provide price per strip in valid format");
                pricePerStrip = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the expiry date for the medicine in mm/dd/yyyy format.");
                expiryDate = DateTime.Parse(Console.ReadLine());
                Medicine chosenGenericMedicine = objMainProgram.CreateMedicineDetail(medicineName.Trim(), genericMedicineName.Trim(), medicineComposition.Trim(), expiryDate, pricePerStrip);

                Console.WriteLine();
                Console.WriteLine("Dear admin, here are the generic medicine details for: " + chosenGenericMedicine.Name);
                Console.WriteLine();
                Console.WriteLine("Generic medicine name: " + chosenGenericMedicine.GenericMedicineName);
                Console.WriteLine("Composition: " + chosenGenericMedicine.Composition);
                Console.WriteLine("Price per strip: " + chosenGenericMedicine.PricePerStrip);
                Console.WriteLine("Expiry date: " + chosenGenericMedicine.ExpiryDate.ToShortDateString());
                #endregion

                #region Carton detail
                Console.WriteLine("Do you want to pack in carton to sell it to a retailer? y/n");
                string response = Console.ReadLine();
                if (response.ToLower().Equals("y"))
                {
                    DateTime launchDate;
                    int medicineStripCount = 0;
                    string retailerAddress = string.Empty;

                    Console.WriteLine("Medicine expiry date: " + medicine.ExpiryDate.ToShortDateString());
                    Console.WriteLine("Please enter the date for which you want to send to retailer in mm/dd/yyyy format. Please check that the launch date should be lesser than the expiry date");
                    launchDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("How many medicine strips do you want to send to retailer?");
                    medicineStripCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please provide the retailer address to whom you want to send these medicines to");
                    retailerAddress = Console.ReadLine();

                    CartonDetail cartonDetail = objMainProgram.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, chosenGenericMedicine);

                    if (cartonDetail != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Dear admin, your medicine carton details are as follows:");
                        Console.WriteLine();
                        Console.WriteLine("Generic medicine name: " + cartonDetail.Medicine.GenericMedicineName);
                        Console.WriteLine("Launch date to retailer: " + cartonDetail.LaunchDate.ToShortDateString());
                        Console.WriteLine("No of medicine strips: " + cartonDetail.MedicineStripCount);
                        Console.WriteLine("Retailer address: " + cartonDetail.RetailerAddress);
                        Console.WriteLine("Total amount: " + cartonDetail.TotalAmount.ToString());
                    }
                    Console.WriteLine();
                    Console.WriteLine("***Thank you. Have a great day***");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("***Thank you. Have a great day***");
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured in the process. Please find the detail: " + ex.Message);
                Console.WriteLine("An exception occured in the process. Exception stack trace: " + ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public Medicine CreateMedicineDetail(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Medicine name cannot be empty. Please provide valid value");
            else if (string.IsNullOrEmpty(genericMedicineName))
                throw new Exception("Generic Medicine name cannot be empty. Please provide valid value");
            else if (string.IsNullOrEmpty(composition))
                throw new Exception("Medicine composition cannot be empty. Please provide valid value");
            else if (pricePerStrip <= 0)
                throw new Exception("Incorrect value for Medicine price per strip. Please provide valid value");
            else if (expiryDate < new DateTime(2021, 3, 7))
                throw new Exception("Incorrect expiry date. Please provide valid value");


            Medicine medicine = new Medicine()
            {
                Name = name,
                GenericMedicineName = genericMedicineName,
                Composition = composition,
                ExpiryDate = expiryDate,
                PricePerStrip = pricePerStrip
            };

            return medicine;
        }

        public CartonDetail CreateCartonDetail(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine)
        {
            if(medicine != null)
            {
                if (medicineStripCount <= 0)
                    throw new Exception("Incorrect strip count. Please check");
                else if (launchDate < DateTime.Now)
                    throw new Exception("Incorrect launch date. Please provide valid value");
                else if (launchDate > medicine.ExpiryDate)
                    throw new Exception("Launch date greater than expiry date. Please check");
                else if (string.IsNullOrEmpty(retailerAddress))
                    throw new Exception("Incorrect retailer address. Please check");

                CartonDetail cartonDetail = new CartonDetail()
                {
                    MedicineStripCount = medicineStripCount,
                    LaunchDate = launchDate,
                    RetailerAddress = retailerAddress,
                    Medicine = medicine,
                    TotalAmount = medicine.PricePerStrip * medicineStripCount
                };

                return cartonDetail;
            }
            return null;
        }
    }
}

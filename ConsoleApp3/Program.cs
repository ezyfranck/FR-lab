using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient;
using ConsoleApp3;
using PortaCapena.OdooJsonRpcClient.Consts;
using System.Text.Json;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using models;
using PortaCapena.OdooJsonRpcClient.Converters;

namespace models
{
    public class AggregatedOrderRecord
    {
        public SaleOrder? SaleOrder { get; set; }
        public Partner? Partner { get; set; }
        public List<OrderLine>? OrderLines { get; set; }
        public List<Product>? Products { get; set; }
        public Currency? Currency { get; set; }
    }
    public class SaleOrder
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public long? PartnerId { get; set; }
        public long? PartnerInvoiceId { get; set; }
        public long? PartnerShippingId { get; set; }
        public long? CurrencyId { get; set; }
        public DateTime? DateOrder { get; set; }
        public DateTime? CommitmentDate { get; set; }
    }

    public class Currency
    {
        public string? FullName { get; set; }
    }


    public class OrderLine
    {
        public long? ProductId { get; set; }
        public double? ProductUomQty { get; set; }
    }

    public class Product
    {
        public string? DefaultCode { get; set; }
        public string? Barcode { get; set; }
        public long? ProductTmplId { get; set; }
    }


    public class Partner
    {
        public string? Name { get; set; }
        public string? Street { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
    }
}

public class Program
{


    // Method GET SALE.ORDER
    public static async Task<List<SaleOrder>> GetRecordsSaleOrder(OdooRepository<SaleOrderOdooModel> model)
    {
        try
        {

            var odooResult = await model.Query()
                    .Where(order => order.State, OdooOperator.EqualsTo, "sale")
                    .Select(order => new
                    {
                        order.Name,
                        order.PartnerId,
                        order.PartnerInvoiceId,
                        order.PartnerShippingId,
                        order.DateOrder,
                        order.CommitmentDate,
                        order.Id,
                        order.CurrencyId 
                    })
                    //.Take(1)  // uncomment to take all orders
                    .ToListAsync();

            if (odooResult.Failed)
            {
                Console.WriteLine("odooResult.Value <GetRecordsSaleOrder>: " + odooResult.Value);
                throw new Exception();
            }

            return odooResult.Value.Select(order => new SaleOrder
            {
                Id = order.Id,
                Name = order.Name,
                PartnerId = order.PartnerId,
                PartnerInvoiceId = order.PartnerInvoiceId,
                PartnerShippingId = order.PartnerShippingId,
                DateOrder = order.DateOrder,
                CommitmentDate = order.CommitmentDate,
                CurrencyId = order.CurrencyId

            }).ToList();

        }
        catch (Exception err)
        {
            throw new Exception("Failed Try <GetRecordsSaleOrder> \n" + err.Message.ToString());
        }

    }


    // Method GET PRODUCT.PRODUCT
    public static async Task<List<Product>> GetRecordsProductProduct(OdooRepository<ProductProductOdooModel> model, long? productId)
    {
        try
        {
            var odooResult = await model.Query()
                .Where(product => product.Id, OdooOperator.EqualsTo, productId)
                .Select(product => new
                    {
                        product.DefaultCode,
                        product.Barcode,
                        product.ProductTmplId
                    })
                .ToListAsync();

            if (odooResult.Failed)
            {
                Console.WriteLine("odooResult.Value <GetRecordsProductProduct>: " + odooResult.Value);
                throw new Exception();
            }

            return odooResult.Value.Select(product => new Product
            {
                DefaultCode = product.DefaultCode,
                Barcode = product.Barcode,
                ProductTmplId = product.ProductTmplId
            }).ToList();

        }
        catch (Exception err)
        {
            throw new Exception("Failed Try <GetRecordsProductProduct> \n" + err.Message.ToString());
        }
    }


    // Method GET SALE.ORDER.LINE
    public static async Task<List<OrderLine>> GetRecordsOrderLine(OdooRepository<SaleOrderLineOdooModel> model, long? OrderId)
    {

        try
        {
            var odooResult = await model.Query()
                    .Where(line => line.OrderId, OdooOperator.EqualsTo, OrderId)
                    .Select(line => new
                    {
                        line.ProductId,
                        line.ProductUomQty
                    })
                   .ToListAsync();

            if (odooResult.Failed)
            {
                Console.WriteLine("odooResult.Value <GetRecordsOrderLine>: " + odooResult.Value);
                throw new Exception();
            }

            return odooResult.Value.Select(line => new OrderLine
            {
                ProductId = line.ProductId,
                ProductUomQty = line.ProductUomQty
            }).ToList();

        }
        catch (Exception err)
        {
            throw new Exception("Failed Try <GetRecordsOrderLine> \n" + err.Message.ToString());
        }
    }


    // Method GET RES.PARTNER
    public static async Task<List<Partner>> GetRecordsPartner(OdooRepository<ResPartnerOdooModel> model, long? PartnerId)
    {
        try
        {
            var odooResult = await model.Query()
                    .ById((long)PartnerId) 
                    .Select(partner => new
                    {
                        partner.Name,
                        partner.Street,
                        partner.Street2,
                        partner.City,
                        partner.Zip,
                        partner.Email,
                        partner.Phone,
                        partner.Mobile
                    })
                   .ToListAsync();

            if (odooResult.Failed)
            {
                Console.WriteLine("odooResult.Value <GetRecordsPartner>: " + odooResult.Value);
                throw new Exception();
            }

            return odooResult.Value.Select(partner => new Partner
            {
                Name = partner.Name,
                Street = partner.Street,
                Street2 = partner.Street2,
                City = partner.City,
                Zip = partner.Zip,
                Email = partner.Email,
                Phone = partner.Phone,
                Mobile = partner.Mobile
            }).ToList();
        }
        catch (Exception err)
        {
            throw new Exception("Failed Try <GetRecordsPartner> \n" + err.Message.ToString());
        }
    }
  
    public static async Task<List<Currency>> GetRecordsCurrency(OdooRepository<ResCurrencyOdooModel> model, long? CurrencyId)
    {
        try
        {
            var odooResult = await model.Query()
                    .ById((long)CurrencyId)
                    .Select(currency => new
                    {
                        currency.FullName
                    })
                   .ToListAsync();

            if (odooResult.Failed)
            {
                Console.WriteLine("odooResult.Value <GetRecordsCurrency>: " + odooResult.Value);
                throw new Exception();
            }

            return odooResult.Value.Select(currency => new Currency
            {
                FullName = currency.FullName,
            }).ToList();
        }
        catch (Exception err)
        {
            throw new Exception("Failed Try <GetRecordsCurrency> \n" + err.Message.ToString());
        }
    }

    // Main
    public static async Task Main()
    {

        try
        {
            string? password = Environment.GetEnvironmentVariable("PORTA_PASSWORD");

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password not found in environment variables.");
                return;
            }


            // CONNEXION
            OdooConfig config = new OdooConfig(
                    apiUrl: "http://localhost:8069",
                    dbName: "test",
                    userName: "franck.rochette@ezytail.com",
                    password: password
                    );

            var odooClient = new OdooClient(config);
            var loginResult = await odooClient.LoginAsync();

            /*
            // get models
            var tableName = "delivery.carrier";
            var modelResult = await odooClient.GetModelAsync(tableName);
            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);
            Console.WriteLine(model);
            }
            */

            
            var start = new Stopwatch();
            start.Start();

            if (loginResult.Value == 2)
            {
                Console.WriteLine("Login success");
                Console.WriteLine("Waiting ... ");

                // GET MODEL SALE.ORDER
                var repositoryOrder = new OdooRepository<SaleOrderOdooModel>(config!);
                // call method GET RECORDS SALE ORDER
                var recordsSaleOrder = await GetRecordsSaleOrder(repositoryOrder);
                
                if (recordsSaleOrder.Count != 0)
                {

                    var aggregatedOrders = new List<AggregatedOrderRecord>();

                    // GET MODELS
                    var repositoryPartner = new OdooRepository<ResPartnerOdooModel>(config!);
                    var repositoryOrderLine = new OdooRepository<SaleOrderLineOdooModel>(config!);
                    var repositoryProductProduct = new OdooRepository<ProductProductOdooModel>(config!);
                    var repositoryCurrency = new OdooRepository<ResCurrencyOdooModel>(config);

                    int nbOrder = 0;

                    foreach (var order in recordsSaleOrder)
                    {
                        /*
                        // test paralelization
                        var tasks = new List<Task>();

                        List<Partner>? recordsPartner = null;
                        List<OrderLine>? recordsOrderLine = null;
                        List<Currency>? recordsCurrency = null;

                        List<Product>? products = null;
                        Partner? partner = null;
                        Currency? currency = null;


                        tasks.Add(Task.Run(async () =>
                        {
                            recordsOrderLine = await GetRecordsOrderLine(repositoryOrderLine, order.Id);
                            products = new List<Product>();
                        }));
                        tasks.Add(Task.Run(async () =>
                        {
                            recordsPartner = await GetRecordsPartner(repositoryPartner, order.PartnerId);
                            partner = recordsPartner.FirstOrDefault();
                        }));
                        tasks.Add(Task.Run(async () =>
                        {
                            recordsCurrency = await GetRecordsCurrency(repositoryCurrency, order.CurrencyId);
                            currency = recordsCurrency.FirstOrDefault();
                        }));
                        await Task.WhenAll(tasks);
                        */

                        nbOrder++;
                        
                        //  test linear
                        var recordsPartner = await GetRecordsPartner(repositoryPartner, order.PartnerId);
                        var partner = recordsPartner.FirstOrDefault();

                        var recordsOrderLine = await GetRecordsOrderLine(repositoryOrderLine, order.Id);
                        var products = new List<Product>();

                        var recordsCurrency = await GetRecordsCurrency(repositoryCurrency, order.CurrencyId);
                        var currency = recordsCurrency.FirstOrDefault();

                        foreach (var line in recordsOrderLine)
                        {
                            var recordsProductProduct = await GetRecordsProductProduct(repositoryProductProduct, line.ProductId);
                            products.AddRange(recordsProductProduct);
                        }

                        aggregatedOrders.Add(new AggregatedOrderRecord
                        {
                            SaleOrder = order,
                            Partner = partner,
                            OrderLines = recordsOrderLine,
                            Products = products,
                            Currency = currency
                        });
                    }

                    var jsonString = JsonSerializer.Serialize(aggregatedOrders, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                    });                       
                    Console.WriteLine(jsonString);
                    Console.WriteLine("Nombre de commande: " + nbOrder);

                }
                else Console.WriteLine("No Orders found !"); 

            start.Stop();
            string elapsedTime = start.Elapsed.ToString();
            Console.WriteLine($"Time: {elapsedTime}");

            }
            else Console.WriteLine("### Login failed !");
        }
            
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
}
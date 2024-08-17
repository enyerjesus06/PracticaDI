using PracticaDI;

public class FakeCustomerRepository : ICustomerRepository
{
    public void GetCustomerById(int id)
    {
        // Implementación simulada para pruebas.
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository fakeRepository = new FakeCustomerRepository();
        CustomerService service = new CustomerService(fakeRepository);

        service.GetCustomer(1); // Usando la implementación simulada.
    }
}


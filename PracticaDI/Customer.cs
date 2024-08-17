using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{

    ////Practica DI.

    ////Simulacion del Problema...
    //public class CustomerRepository
    //{
    //    public void GetCustomerById(int id)
    //    {
    //        // Lógica para obtener un cliente por su ID.
    //    }
    //}

    //public class CustomerService
    //{
    //    private readonly CustomerRepository _customerRepository;

    //    public CustomerService()
    //    {
    //        _customerRepository = new CustomerRepository(); // Dependencia directa.
    //    }

    //    public void GetCustomer(int id)
    //    {
    //        _customerRepository.GetCustomerById(id);
    //    }
    //}




    //Solución usando Inyección de Dependencias...

    // Definir una interfaz para el repositorio.
    public interface ICustomerRepository
    {
        void GetCustomerById(int id);
    }

    // Implementación concreta del repositorio.
    public class CustomerRepository : ICustomerRepository
    {
        public void GetCustomerById(int id)
        {
            // Lógica para obtener un cliente por su ID.
        }
    }

    // Clase CustomerService que depende de la interfaz en lugar de la implementación concreta.
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        // Inyección de dependencias a través del constructor.
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void GetCustomer(int id)
        {
            _customerRepository.GetCustomerById(id);
        }
    }


}
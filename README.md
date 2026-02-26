# Siemens Internship Assignment 2026 - DevOps & Fullstack

Acest repository conține rezolvarea pentru assignment-ul tehnic din cadrul procesului de selecție pentru internship-ul Siemens (Azure/.NET/Fullstack).

## Structura Proiectului

Proiectul este împărțit în două foldere principale, conform cerințelor:

### 1. CoffeeShop (Problem 1 - Arhitectură și Baze de Date)

Conține diagramele realizate pentru modelarea sistemului unei cafenele:

- **Class Diagram (OOP):** Ilustrează entitățile (Drink, Order, Customer etc.), proprietățile acestora și relațiile de compoziție/asociere dintre ele.
- **ER Diagram (Baze de Date):** Ilustrează structura relațională, incluzând cheile primare (PK), cheile străine (FK) și tabelele de legătură (Bridge Tables) pentru gestionarea relațiilor Many-to-Many (ex: `OrderItem`, `OrderItemExtra`).
- _Fișierele sunt disponibile atât în format sursă (.drawio), cât și exportate ca imagini (.png) pentru o vizualizare rapidă._

### 2. SieMarket (Problem 2 - C# & LINQ)

Conține o aplicație de tip Console App scrisă în C# care modelează sistemul unui magazin de electronice.

- **Tehnologii folosite:** C#, LINQ.
- **Funcționalități implementate:**
  - Modele de date (`Order`, `OrderItem`) folosind proprietăți moderne cu `init`.
  - Calculul prețului final cu aplicarea regulilor de discount (10% pentru comenzi > 500€).
  - Extragerea clientului cu cele mai mari cheltuieli folosind interogări LINQ.
  - (Bonus) Extragerea celor mai populare produse și a cantităților vândute, returnate sub formă de dicționar.

## Cum se rulează codul

1. Deschideți soluția/folderul `SieMarket` în Visual Studio.
2. Setați proiectul ca Startup Project (dacă este cazul).
3. Rulați aplicația (F5). Datele de test (Mock Data) sunt deja inițializate în `Program.cs` pentru a demonstra funcționalitatea metodelor.

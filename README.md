*Single-Responsability:
   În acest cod, avem o clasă Program care conține metoda Main. Această metodă creează o instanță a clasei Calculator și apelează metoda sa Add pentru a efectua o simplă operație de adunare.

Clasa Calculator are doar o singură responsabilitate, și anume de a efectua calcule matematice. Ea are o singură metodă, Add, care primește două numere întregi ca intrare și returnează suma lor. Acest lucru înseamnă că clasa Calculator are un singur motiv pentru a fi modificată - dacă avem nevoie să adăugăm mai multe operații matematice, putem adăuga noi metode în clasa Calculator fără a modifica codul existent.

Prin urmarea Principiului Single-Responsability, putem face codul nostru mai modular, mai ușor de întreținut și mai puțin predispus la erori.

*Open_Close:
În acest cod, avem o clasă Program care conține metoda Main. Această metodă creează o instanță a clasei AddCalculator care implementează interfața ICalculator și apelează metoda sa Calculate pentru a efectua o simplă operație de adunare.

  Interfața ICalculator definește o singură metodă Calculate care primește două numere întregi ca intrare și returnează rezultatul lor. Acest lucru înseamnă că putem adăuga noi clase de calculator care implementează interfața ICalculator pentru diferite operații matematice, cum ar fi scăderea, înmulțirea sau împărțirea, fără a modifica codul existent.

Prin urmarea Principiului Open-Close, putem face codul nostru mai extensibil, mai ușor de întreținut și mai puțin predispus la erori, deoarece putem adăuga noi funcționalități prin crearea de noi clase care implementează interfețe existente, în loc să modificăm codul existent.

*Liskov-Substitution:
  În acest cod, avem o clasă Program care conține metoda Main. Această metodă creează o instanță a clasei AddCalculator, care este o subclasă a clasei abstracte Calculator, și apelează metoda sa Calculate pentru a efectua o simplă operație de adunare.

Clasa Calculator este o clasă abstractă care definește o singură metodă Calculate care primește două numere întregi ca intrare și returnează rezultatul lor. Acest lucru înseamnă că putem adăuga noi clase de calculator care moștenesc din clasa Calculator pentru diferite operații matematice, cum ar fi scăderea, înmulțirea sau împărțirea, fără a modifica codul existent.

Clasele AddCalculator și SubtractCalculator moștenesc ambele din clasa Calculator și suprascriu metoda Calculate pentru a implementa funcționalitatea lor specifică. Deoarece ambele subclase satisfac contractul clasei Calculator, putem utiliza aceste clase interschimbabil, fără a schimba comportamentul programului.

Prin urmarea Liskov-Substitution, putem asigura că codul nostru este mai flexibil și mai ușor de întreținut, deoarece putem adăuga noi subclase care extind funcționalitatea claselor existente, fără a modifica comportamentul restului codului.

*Interface-Segregation:
  În acest cod, avem o clasă Program care conține metoda Main. Această metodă creează o instanță a clasei AddCalculator, care implementează interfața IAddCalculator, și apelează metoda sa Add pentru a efectua o simplă operație de adunare.

Interfața IAddCalculator definește o singură metodă Add care primește două numere întregi ca intrare și returnează suma lor. Similar, interfața ISubtractCalculator definește o singură metodă Subtract care primește două numere întregi ca intrare și returnează diferența lor.

Clasa AddCalculator implementează interfața IAddCalculator și suprascrie metoda sa Add pentru a efectua operația de adunare. Clasa SubtractCalculator implementează interfața ISubtractCalculator și suprascrie metoda sa Subtract pentru a efectua operația de scădere.

Prin urmarea Interface-Segregation, putem asigura că codul nostru este mai modular și mai coerent, deoarece fiecare interfață definește o singură responsabilitate care poate fi implementată de una sau mai multe clase. Acest lucru ne permite să creăm clase și interfețe mai specializate și concentrate, care sunt mai ușor de înțeles și de întreținut.

*Dependency-Inversion:
  Principiul Dependency-Inversion (DIP) stipulează că modulele de nivel ridicat nu ar trebui să depindă de modulele de nivel scăzut. Ambele ar trebui să depindă de abstracțiuni. Abstracțiunile nu ar trebui să depindă de detalii. Detaliile ar trebui să depindă de abstracțiuni.

În acest exemplu, am introdus o nouă interfață IOperation care definește contractul pentru toate operațiile aritmetice. Apoi am implementat două clase AddOperation și SubtractOperation care implementează interfața IOperation și definesc operațiile aritmetice efective.

În cele din urmă, am modificat clasa Calculator pentru a accepta IOperation ca parametru de constructor și apoi să utilizeze acea operație pentru a calcula rezultatul. Prin acest lucru, clasa Calculator nu mai depinde de detaliile de implementare ale AddOperation sau SubtractOperation. În schimb, depinde de o abstracțiune IOperation. Acest lucru ne permite să schimbăm ușor diferite implementări ale IOperation fără a afecta clasa Calculator.
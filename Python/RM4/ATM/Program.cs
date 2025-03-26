balanca = 10000

while True:
    print("\nBalanca e llogarise: ", balanca)
    print("1. Depozito")
    print("2. Terheq")
    print("3. Dil")

    zgjedhja = input("Zgjidh nje numer (1/2/3): ")

    if zgjedhja == "1":
        try:
            shuma = float(input("Sa lek do depozitosh? "))
            if shuma <= 0:
                print("Shuma qe ju keni futur eshte negative.")
            else:
                balanca += shuma
                print(f"Ke depozituar {shuma} lek.")
        except ValueError:
            print("Gabim ne sintaks. Ju lutem futni nje numer te vlefshem.")


    elif zgjedhja == "2":
        try:
            shuma = float(input("Sa lek do terheqesh? "))
            if shuma <= 0:
                print("Shuma qe ju keni futur eshte negative.")
            else:
                balanca -= shuma
                print(f"Ke terhequr {shuma} lek.")
        except ValueError:
            print("Gabim ne sintaks. Ju lutem futni nje numer te vlefshem.")


    elif zgjedhja == "3":
        print("Exit!")
        break


    else:
        print("Ju nuk mund te beni kete zgjedhje!")

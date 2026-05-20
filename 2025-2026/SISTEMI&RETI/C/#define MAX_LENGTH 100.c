#define MAX_LENGTH 100

// define struct BookLoan

// define struct InventoryBook

/**
 * createMenu creates a user menù with the following options:
 * 1 - Print current loans count
 * 2 - Get book inventory
 * 3 - Add new book loan
 * 4 - Add new book to inventory
 * 5 - Print user loans
 * If the line is empty, -1 is returned
 * If the choice is valid, its number is returned.
 */
int createMenu() {
  printf("1 - Print current loans count\n");
  printf("2 - Get book inventory\n");
  printf("3 - Add new book loan\n");
  printf("4 - Add new book to inventory\n");
  printf("5 - Print user loans\n");

  int choice;
  scanf("%d", &choice);

  if (choice < 1 || choice > 5)
  {
    return -1;
  }

  return choice;
}

/**
 * doOperation takes the number representing a choice and
 * executes the corresponding operation
 * Returns -1 in case of any error.
 */
int doOperation(int choice) {
  int tempCount;
  BookLoan tempLoan;
  InventoryBook tempBook;
  char personName[MAX_LENGTH];

  switch(choice)
  {
    case 1:
      tempCount = getCurrentLoanCount();
      if (tempCount == -1)
      {
        printf("Errore\n");
        return -1;
      }

      printf("%d\n", tempCount);

      return 0;
    case 2:
      return printBookInventory();
    case 3:
      printf("Inserisci il nome della persona: ");
      scanf("%s", tempLoan.person);
      printf("Inserisci il nome del libro: ");
      scanf("%s", tempLoan.book);

      return addNewLoan(tempLoan);
    case 4:
      printf("Inserisci il nome del libro: ");
      scanf("%s", tempBook.name);
      printf("Inserisci il numero di copie: ");
      scanf("%d", &tempBook.copies);

      return addNewBookInInventory(tempBook);
    case 5:
      printf("Inserisci il nome della persona: ");
      scanf("%s", personName);

      return printUserLoans(personName);
    default:
      return -1;
  }

  return 0;
}

/**
 * getCurrentLoanCount returns the number of loans available in the
 * "loans.txt" file.
 * Returns -1 in case of any error.
 */
int getCurrentLoanCount() {
  FILE *fp = fopen("loans.txt", "r");
  if (fp == NULL)
  {
    return -1;
  }

  int count = 0;

  while (!feof(fp))
  {
    BookLoan temp;
    fscanf(fp, "%s %s\n", temp.person, temp.book);

    count++;
  }

  return count;
}

/**
 * printBookInventory prints each book and number of copies in the inventory
 * file "books.txt", one by line, with the following format
 *
 * Book Name - Number of copies
 *
 * Example
 *
 * Zibaldone - 5
 * Astrology_For_Dummies - 1
 */
int printBookInventory() {
  // implement function logic here
  return -1;
}

/**
 * addNewLoan adds a new loan to the loans file.
 * Returns -1 in case of any error.
 */
int addNewLoan(BookLoan loan) {
  // implement function logic here
  return -1;
}

/**
 * addNewBookInInventory adds a new book to the inventory file.
 * Returns -1 in case of any error.
 */
int addNewBookInInventory(InventoryBook book) {
  // implement function logic here
  return -1;
}

/**
 * printUserLoans prints all the books loaned to a user with
 * the specified name.
 * Returns -1 in case of any error.
 */
int printUserLoans(char name[MAX_LENGTH]) {
  // implement function logic here
  return -1;
}
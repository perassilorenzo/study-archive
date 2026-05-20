#define MAX_STR_LENGTH 30
#define MAX_LENGTH 100

#include <stdlib.h>
#include <string.h>
#include <stdio.h>

typedef struct {
    char name[MAX_STR_LENGTH];
    char species[MAX_STR_LENGTH];
    int petals;
} Flower;

// Prototypes of the functions to be implemented
int initialize_flower(Flower*, char*, char*, int);
int serialize_flower(Flower*, char*);
int unserialize_flower(Flower*, char*);
int sort_flowers_by_petals(Flower*, int);
void print_flower(Flower*);
void print_flowers(Flower*, int);

/**
 * @brief Initializes a Flower structure with the given parameters.
 * @param f Pointer to the Flower structure to initialize
 * @param name The name of the flower
 * @param species The species of the flower
 * @param petals The number of petals
 * @return 0 on success, non-zero on failure
 */
int initialize_flower(Flower* f, char *name, char *species, int petals) {
    if (f == NULL || name == NULL || species == NULL || petals < 0) return -1;

    strcpy(f->name, name);
    strcpy(f->species, species);
    f->petals = petals;

    return 0;
}

/**
 * @brief Serializes a Flower structure to a file.
 * @param f Pointer to the Flower structure to serialize
 * @param filename The name of the file to write to
 * @return 0 on success, non-zero on failure
 */
int serialize_flower(Flower* f, char *filename) {
    if (f == NULL || filename == NULL) return -1;

    FILE* file = fopen(filename, "w");
    if (file == NULL) return -1;

    fprintf(file, "%s\n%s\n%d\n", f->name, f->species, f->petals);

    fclose(file);
    return 0;
}

/**
 * @brief Unserializes a Flower structure from a file.
 * @param f Pointer to the Flower structure to populate
 * @param filename The name of the file to read from
 * @return 0 on success, non-zero on failure
 */
int unserialize_flower(Flower* f, char *filename) {
    if (f == NULL || filename == NULL) return -1;

    FILE* file = fopen(filename, "r");
    if (file == NULL) return -1;

    fscanf(file, "%s\n%s\n%d\n", f->name, f->species, &f->petals);

    fclose(file);
    return 0;
}

/**
 * @brief Sorts an array of flowers by the number of petals in ascending order.
 * @param flowers Array of Flower structures to sort
 * @param n The number of flowers in the array
 * @return 0 on success, non-zero on failure
 */
int sort_flowers_by_petals(Flower *flowers, int n) {
    if (flowers == NULL || n <= 0) return 0;

    for (int i = 0; i < n - 1; i++){
        for (int j = 0; j < n - 1 - i; j++){
            if (flower[j].petals > flower[j+1].petals){
                Flower temp = flower[j];
                flower[j] = flower[j+1];
                flower[j+1] = flower[j];
            }
        }
    }

    return 0;
}

/**
 * @brief Prints a single flower to the standard output.
 * @param f Pointer to the Flower structure to print
 */
void print_flower(Flower* f) {
    if (f == NULL) return;
    printf("Name: %s\nSpecies: %s\n Petals: %d\n", f->name, f->species, f->petals);
}

/**
 * @brief Prints an array of flowers to the standard output.
 * @param flowers Array of Flower structures to print
 * @param n The number of flowers in the array
 */
void print_flowers(Flower *flowers, int n) {
    if (flowers == NULL || n <= 0) return;

    for (int i = 0; i < n; i++){
        print_flower(&flowers[i]);
        printf("\n");
    }
}

/**
 * @brief Selects a random flower from an array of flowers. If the array 
 * is empty, returns -1.
 * @param f Pointer to the Flower structure to populate with the random flower
 * @param flowers Array of Flower structures to select from
 * @param n The number of flowers in the array
 * @return 0 on success, non-zero on failure
 */
int random_flower(Flower* f, Flower* flowers, int n) {
    if (f == NULL || flowers == NULL || n <= 0) return -1;

    int i = rand() % n;
    *f = flowers[i];

    return 0;
}
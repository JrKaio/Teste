#include <stdio.h>
#include <string.h>

void inverteString(char *str) {
    int tamanho = strlen(str);
    int i;
    char temp;

    for (i = 0; i < tamanho/2; i++) {
        temp = str[i];
        str[i] = str[tamanho-i-1];
        str[tamanho-i-1] = temp;
    }
}

int main() {
    char str[100];

    printf("Digite uma string: ");
    fgets(str, 100, stdin);

    inverteString(str);

    printf("A string invertida é: %s", str);

    return 0;
}

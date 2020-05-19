#include <stdio.h>
#include <stdlib.h>

#define max(x, y) ( (x) > (y) ? (x) : (y) )
#define min(x, y) ( (x) < (y) ? (x) : (y) )
#define true 1 == 1
#define false 1 != 1

typedef int boolean;

typedef struct Node
{
    int key;
    struct Node *left;
    struct Node *right;
} TreeNode;

void printTree(TreeNode *root)
{
    if (root)
    {
        printf("%d", root->key);
        if (root->left || root->right)
        {
            printf("(");
            if (root->left)
                printTree(root->left);
            else
                printf("NULL");
            printf(",");
            if (root->right)
                printTree(root->right);
            else
                printf("NULL");
            printf(")");
        }
    }
}

TreeNode* balancedTree(int n)
{
    TreeNode *newNode;
    int x;
    int nL;
    int nR;

    if (n==0)
    {
        return NULL;
    }
    else
    {
        x = 1 + rand() % 100;
        nL = n / 2;
        nR = n - nL - 1;
        newNode = (TreeNode*) malloc(sizeof(TreeNode));
        newNode->key = x;
        newNode->left = balancedTree(nL);
        newNode->right = balancedTree(nR);
    }
    return newNode;
}

TreeNode* treeInsert(TreeNode *t, int data)
{
    TreeNode *newNode;
    newNode = (TreeNode*) malloc(sizeof(TreeNode));
    newNode->key = data;
    newNode->left = NULL;
    newNode->right = NULL;
    TreeNode *current = t;
    TreeNode *parent = t;
    if (t == NULL)
    {
        t = newNode;
    }
    else
    {
        while (current->key != data)
        {
            parent = current;
            if (current->key > data)
            {
                current = current ->left;
                if (current == NULL)
                {
                    parent->left = newNode;
                    return t;
                }
            }
            else
            {
                current = current ->right;
                if (current == NULL)
                {
                    parent->right = newNode;
                    return t;
                }
            }
        }
    }
}

int BalancedOrNot(TreeNode * node)
{
    if(node == 0)
        return 0;
    int left0, right0;
    if (node->left != NULL) {
        left0 = BalancedOrNot(node->left);
    }else 
        left0 = -1;
    if (node->right != NULL) {
        right0 = BalancedOrNot(node->right);
    }else 
        right0 = -1;
    int dif;
    int max0 = max(right0, left0);
    int min0 = min(right0, left0);
    dif = max0 - min0;
    //return max0+1;
    return dif;
}

boolean binSearch(TreeNode *root, int value)
{
    if (root == NULL)
        return false;
    if (root->key == value)
        return true;
    TreeNode *current = root;
    if (current->key != value)
    {
        if (value < current->key)
        {
            current = current->left;
            binSearch(current, value);
        }
        else
        {
            current = current->right;
            binSearch(current, value);
        }
        if (current == NULL)
            return false;
    }
}

int main()
{
    TreeNode *tree = NULL;
    const int count = 10000;
    int x;
    float balNum;

    balNum = 0;
    //tree = treeInsert(tree, 10);
    srand(time(NULL));
    x = 1 + rand() % 100000000;
    tree = treeInsert(tree, x);
    for(int j = 0; j < 50; j++)
    {
    for(int i = 0; i < count; i++)
    {
        x = 1 + rand() % 100000000;
        treeInsert(tree, x);
       // printf("%d ", x);
    }
    //printf("%d ", BalancedOrNot(tree));
    if (BalancedOrNot(tree) <= 1)
        balNum++;
    }
    balNum = balNum / 50 * 100;
    printf("%.0f", balNum);
    printf("%%");
    return 0;
}
#include <stdio.h>
#include <stdlib.h>

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
    const int count = 15;
    tree = treeInsert(tree, 10);
    tree = treeInsert(tree, 1);
    tree = treeInsert(tree, 3);
    tree = treeInsert(tree, 12);
    tree = treeInsert(tree, 11);
    tree = treeInsert(tree, 21);
    tree = treeInsert(tree, 7);
    printTree(tree);
    printf("\n");
    printf("11 in tree = %s \n", binSearch(tree, 11) ? "true" : "false");
    printf("31 in tree = %s \n", binSearch(tree, 31) ? "true" : "false");
    return 0;
}
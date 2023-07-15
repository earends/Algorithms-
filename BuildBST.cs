using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string nodeCount = Console.In.ReadLine();
        
        string nodes = Console.In.ReadLine();
        Node root = BuildNodeTree(nodes);
      
      
    }
    
    static Node BuildNodeTree(string nodeList){
        
        string [] nodeArray = nodeList.Split(new string [] { " "}, StringSplitOptions.RemoveEmptyEntries);
        Node root = null;
        foreach(string item in nodeArray){
            int dataVal = int.Parse(item);
            root = AddNodeToTree(root, dataVal);
            //Console.Out.WriteLine(root == null ? "null" : root.data );
        }
        
        return root;
        
        // if the node value you are on is less than 1 value
        // but greater than another value then that is going 
        // to be your common root
        
        // but if they are both less than or greater than you value
        // you can go down one more layer
        // so you stop when your root value is greater than 1 and less than another
    }
    
    
    
    static Node AddNodeToTree(Node root, int val)
    {
        if (root == null){
            return new Node() {data = val };
        }
        
        if (val > root.data){
            if (root.right == null)
            {
                root.right = new Node() { data = val};
                return root;
            }
            else {
                root.right = AddNodeToTree(root.right, val);
                return root;
            }
        }
        else {
            if (root.left == null){
                root.left = new Node() { data = val};
                return root;
            }
            else {
                root.left = AddNodeToTree(root.left, val);
                return root;
            }
        }
    }
}

public class Node{
    public int data {get; set;}
    public Node left {get; set;}
    public Node right {get; set;}
}

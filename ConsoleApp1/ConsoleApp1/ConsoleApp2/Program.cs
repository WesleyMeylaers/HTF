using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define the custom alphabet
        Dictionary<char, char> alphabet = new Dictionary<char, char>
        {
            {'∆', 'A'}, {'⍟', 'B'}, {'◊', 'C'}, {'Ψ', 'D'}, {'Σ', 'E'},
            {'ϕ', 'F'}, {'Ω', 'G'}, {'λ', 'H'}, {'ζ', 'I'}, {'Ϭ', 'J'},
            {'ↄ', 'K'}, {'◯', 'L'}, {'⧖', 'M'}, {'⊗', 'N'}, {'⊕', 'O'},
            {'∇', 'P'}, {'⟁', 'Q'}, {'⎍', 'R'}, {'φ', 'S'}, {'✦', 'T'},
            {'⨅', 'U'}, {'ᚦ', 'V'}, {'ϡ', 'W'}, {'⍾', 'X'}, {'⍝', 'Y'},
            {'≈', 'Z'}
        };

        // Encoded message
        string encodedMessage = "ϡλΣ⊗ λ⨅⧖∆⊗ζ✦⍝ ⧖∆ΨΣ ϕζ⎍φ✦ ◊⊕⊗✦∆◊✦ ϡζ✦λ ✦λΣ φ∇Σ◊ζΣφ ↄ⊗⊕ϡ⊗ ⊕⊗◯⍝ ∆φ '✦λΣ ϡ∆✦◊λΣ⎍φ,' ζ✦ ⍟Σ◊∆⧖Σ ◊◯Σ∆⎍ ✦λ∆✦ ✦λΣ⍝ λ∆Ψ ⊕⍟φΣ⎍ᚦΣΨ Σ∆⎍✦λ ϕ⊕⎍ ⧖ζ◯◯Σ⊗⊗ζ∆, ⊗⊕✦ ζ⊗✦Σ⎍ϕΣ⎍ζ⊗Ω, ⍟⨅✦ φ⨅⍟✦◯⍝ Ω⨅ζΨζ⊗Ω Σᚦ⊕◯⨅✦ζ⊕⊗, Σ⊗φ⨅⎍ζ⊗Ω ✦λΣ φ⨅⎍ᚦζᚦ∆◯ ⊕ϕ ✦λΣ φ∇Σ◊ζΣφ ✦λΣ⍝ λ∆Ψ ◊λ⊕φΣ⊗ ✦⊕ ∇⎍⊕✦Σ◊✦.";

        // Decode the message
        string decodedMessage = DecodeMessage(encodedMessage, alphabet);

        // Print the decoded message
        Console.WriteLine("Decoded Message: " + decodedMessage);
    }

    static string DecodeMessage(string message, Dictionary<char, char> alphabet)
    {
        string decoded = "";
        foreach (char c in message)
        {
            if (alphabet.ContainsKey(c))
            {
                decoded += alphabet[c];
            }
            else
            {
                decoded += c; // Keep spaces and unknown characters as is
            }
        }
        return decoded;
    }
}
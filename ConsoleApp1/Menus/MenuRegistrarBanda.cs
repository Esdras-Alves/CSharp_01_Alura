using OpenAI_API;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine();
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);

            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            banda.Resumo = resposta;
            
            Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

/*  Desafio: aprimorar a taxa de renovação de assinaturas
    Foi solicitado que você adicionasse um recurso ao software de sua empresa. 
    O recurso destina-se a melhorar a taxa de renovação das assinaturas do software. 
    Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer logon
    no sistema de software e receber a notificação de que a assinatura está prestes a ser encerrada. 
    Você precisará adicionar um par de instruções de decisão para adicionar corretamente
    a lógica de ramificação ao aplicativo para atender aos requisitos.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);

// Regra 1: seu código deve exibir apenas uma mensagem.

    /*A mensagem exibida pelo código dependerá das outras cinco regras. 
    Para as regras de 2 a 6, as regras numeradas mais altas têm precedência 
    sobre as regras numeradas mais baixas.
    */

//Regra 2: se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem:

    //Your subscription will expire soon. Renew now!

//Regra 3: se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem:

    //Your subscription expires in _ days.
    //Renew now and save 10%!

//Regra 4: se a assinatura do usuário expirar em um dia, serão exibidas as mensagens:

    //Your subscription expires within a day!
    //Renew now and save 20%!

//Regra 5: se a assinatura do usuário tiver expirado, será exibida a mensagem:

    //Your subscription has expired.

if(daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");

    if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");

        if(daysUntilExpiration == 1)
        {
            Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
        }
    }
}
else
{
    Console.WriteLine("Your subscription has expired.");
}

Console.WriteLine(daysUntilExpiration);

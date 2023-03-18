using Microsoft.AspNetCore.Mvc;
using notas.api01.Models;
using System;
using System.Net;
using Microsoft.Extensions.Logging;

namespace notas.api01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {


        [HttpGet("calcular-media")]
        public ActionResult<string> CalcularMedia([FromQuery(Name = "nota1")] double nota1, [FromQuery(Name = "nota2")] double nota2)
        {




            string resultado;
            try
            {
                if (nota1 < 0 || nota2 < 0)
                {
                    throw new ArgumentException("Sistema não permite notas abaixo de zero");
                }



                double media = (nota1 + nota2) / 2;


                    switch (media)
                    {
                        case double m when m >= 7:
                            return resultado = $"Aluno foi aprovado com a nota: {media}";
                        case double m when m >= 4:
                            return resultado = $"Aluno está de recuperação  com a nota: {media}";
                        default:
                            return resultado = $"Aluno está reprovado  com a nota: {media}";
                    }
            }
            catch(ArgumentException msgexpt)
            {
                return BadRequest(msgexpt.Message);
            }

            }





        }
    }


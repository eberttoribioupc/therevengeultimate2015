<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                   xmlns:p="http://bankingsample/EmailNotificationProxy/"
                   version="1.0">
      <xsl:output method="xml" omit-xml-declaration="yes" indent="yes"/>
      <xsl:template match="/">
         <div style="width:400px">
            <h3 style="color:#444;font-weight:bold;border-bottom:dotted 1px #000;padding:1px 0px 1px 0px;text-align:center">
              Datos de nueva Cuenta
            </h3>
            <div>
               <p style="text-align:center">Se le ha registrado una cuenta en EYESuite
              </p>
            </div>
            <table>
               <thead>
                  <p>Detalle</p>
               </thead>
               <tbody>
                  <tr>
                     <td>Name</td>
                     <td>
                        <xsl:value-of select="//p:notifyViaEmailUsuario/name"/>
                     </td>
                  </tr>
                  <tr>
                     <td>usuario:</td>
                     <td>
                        <xsl:value-of select="//p:notifyViaEmailUsuario/email"/>
                     </td>
                  </tr>
                  <tr>
                     <td>Password:</td>
                     <td>
                       <xsl:value-of select="//p:notifyViaEmailUsuario/dni"/>
                     </td>
                  </tr>                  
               </tbody>
            </table>
         </div>
      </xsl:template>
   </xsl:stylesheet>

<?xml version='1.0'?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
    <html>
        <head>
            <style>
                table, th, td {
                    border: 1px solid black;
                    border-collapse: collapse;
                }
            </style>
        </head>
        <body>
            <table>
                <tr>
                    <th>Fecha</th>
                    <th>Máxima</th>
                    <th>Mínima</th>
                    <th>Predicción</th>
                </tr>
                <xsl:for-each select="/root/prediccion/dia">
                    <tr>
                        <td><xsl:value-of select="@fecha"/></td>
                        <td><xsl:value-of select="temperatura/maxima"/></td>
                        <td><xsl:value-of select="temperatura/minima"/></td>
                        <td><img src="{concat('images/',estado_cielo/@descripcion)}.png"/></td>
                    </tr>
                </xsl:for-each>
            </table>
        </body>
    </html>
</xsl:template>

</xsl:stylesheet>
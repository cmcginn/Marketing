<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:extensions="urn:extensions">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <xsl:element name="Posts">
      <xsl:apply-templates select="/Posts/Post"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="/Posts/Post">
    <xsl:variable name="body" select="/Posts/Post/html/body//div[@id='userbody']"></xsl:variable>
    <xsl:element name="Post">
      <xsl:element name="Title">
        <xsl:value-of select="./html/head/title/text()"/>
      </xsl:element>
    </xsl:element>
    <xsl:element name="Body">
      <xsl:copy-of select="extensions:GetCraigslistJobDetails($body)"/>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>

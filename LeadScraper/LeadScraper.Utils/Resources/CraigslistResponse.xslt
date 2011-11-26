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
    <xsl:variable name="body" select ="/Posts/Post/html/body"></xsl:variable>
    <xsl:variable name="userbody" select="/Posts/Post/html/body//div[@id='userbody']"></xsl:variable>
    <xsl:variable name="head" select="/Posts/Post/html/body//div[@class='bchead']"></xsl:variable>
    <xsl:element name="Post">
      <xsl:attribute name="datetime">
        <xsl:value-of select="substring-before(substring-after($body,'Date: '),'&#xA;')"/>
      </xsl:attribute>
      <xsl:call-template name="head"></xsl:call-template>
      <xsl:call-template name="contact"></xsl:call-template>
      <xsl:element name="Title">
        <xsl:value-of select="./html/head/title/text()"/>
      </xsl:element>
    </xsl:element>
    <xsl:element name="Body">
      <xsl:call-template name="blurbs">
      </xsl:call-template>
      <xsl:copy-of select="extensions:GetCraigslistJobDetails($userbody)"/>
    </xsl:element>
  </xsl:template>
  <xsl:template name="blurbs">
    <xsl:variable name="blurbs" select="*//ul[@class='blurbs']"></xsl:variable>
    <xsl:for-each select="$blurbs/li">
      <xsl:if test="contains(text(),':')">
        <xsl:element name="Blurb">
          <xsl:element name="Key">
            <xsl:value-of select="substring-before(text(),':')"/>
          </xsl:element>
          <xsl:element name="Value">
            <xsl:value-of select="normalize-space(substring-after(text(),':'))"/>
          </xsl:element>
        </xsl:element>
      </xsl:if>
    </xsl:for-each>
  </xsl:template>
  <xsl:template name="head">
    <xsl:variable name="head" select="./html/body/div[@class='bchead'] /a[@id='ef']/@href"></xsl:variable>
    <xsl:copy-of select="$head"/>
    <xsl:attribute name="id">
      <xsl:value-of select="substring-before(substring-after($head,'postingID='),'&amp;')"/>
    </xsl:attribute>
  </xsl:template>
  <xsl:template name="contact">
    <xsl:variable name="contact" select="*//a[contains(@href,'mailto:')]"></xsl:variable>
    <xsl:attribute name="contact">
      <xsl:value-of select="$contact/@href"/>
    </xsl:attribute>
  </xsl:template>
</xsl:stylesheet>

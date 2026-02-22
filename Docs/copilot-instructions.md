<!--
AI-GOVERNANCE:
Authority-Level: 1
Role: AI Behavioral Instructions
Applies-To: All code generation and modification
Overrides: requirements.md, architecture.md, standards.md
Compliance: Mandatory
-->

# Copilot Instructions

## General Rules
- Follow governance.md at all times
- Read all governing documents before modifying code
- Do not invent requirements
- Do not change framework versions unless explicitly instructed

## Modification Rules
- Modify existing projects only unless explicitly instructed
- Do not add dependencies without approval
- Prefer minimal, explicit code over clever solutions

## Safety Rule
If a request conflicts with any governing document, \*\*refuse and explain why\*\*.

## Visibility Rule
If a governing document is not currently open, the assistant must still comply with it.

## Visual Studio Context Rule
Pinned documents represent current authority and focus.
Unpinned governing documents remain mandatory even if not visible.

If context is insufficient, request clarification instead of assuming.

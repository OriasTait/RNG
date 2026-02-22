<!--
AI-GOVERNANCE:
Authority-Level: 0
Role: Root Governance
Applies-To: Entire repository
Overrides: All other documents
Compliance: Mandatory
-->

# Governance

## Purpose
This file defines how authority works in this repository.

## Mandatory Read Order
Before creating or modifying any code, an AI assistant must read:
1. governance.md
2. copilot-instructions.md
3. requirements.md
4. architecture.md
5. constraints.md
6. standards.md
7. tasks.md (if present)

## Conflict Resolution

- Lower Authority-Level numbers override higher numbers
- Constraints override preferences
- Explicit rules override inferred behavior

## AI Behavior Rule
If any ambiguity exists, **ask for clarification instead of guessing**.




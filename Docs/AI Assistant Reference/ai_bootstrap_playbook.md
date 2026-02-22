# AI Bootstrap Playbook

## Purpose

This playbook defines a **repeatable process** for bootstrapping an AI-governed software repository *before any solution or code exists*.

It ensures:
- Clear separation of concerns
- Stable document hierarchy
- Minimal scope bleed
- Predictable AI behavior

This process is tool-agnostic but assumes use of:
- A general-purpose LLM (e.g., ChatGPT Free) for design reasoning
- Copilot (inside Visual Studio) for execution alignment

---

# Phase 0 – Ground Rules

Before generating any document, begin the session with this Meta-Anchor Prompt:

```
We are bootstrapping an AI-governed software repository.

Each document serves a distinct authority level.
You must not mix responsibilities across documents.
If any information is unclear, ask clarification questions before generating content.

Output only valid Markdown.
```

This establishes role discipline and reduces cross-contamination.

---

# Document Creation Order (Mandatory)

Documents must be generated in this exact order:

1. constraints.md
2. requirements.md
3. architecture.md
4. governance.md
5. copilot-instructions.md
6. standards.md
7. tasks.md (optional, last)

The order matters because each document depends on the previous ones.

---

# Phase 1 – Define Reality (constraints.md)

## Goal
Define hard, non-negotiable limits.

## Anchor Prompt

```
We are designing a software system with the following known facts:

[List technical and operational facts]

Generate constraints.md.

This file must:
- Contain only non-negotiable constraints
- Avoid preferences
- Avoid implementation details
- Avoid architecture
- Be written as enforceable rules
```

## Output Characteristics
- Declarative
- Non-interpretive
- No solution design

---

# Phase 2 – Define Behavior (requirements.md)

## Goal
Define what the system must do.

## Anchor Prompt

```
Using the constraints defined below:

[Paste constraints]

Generate requirements.md.

This document must:
- Define functional requirements
- Define non-functional requirements
- Clearly define in-scope and out-of-scope
- Avoid architecture and coding details
```

## Output Characteristics
- User-facing
- Technology-light where possible
- No structural decisions

---

# Phase 3 – Define Structure (architecture.md)

## Goal
Define high-level structural boundaries.

## Anchor Prompt

```
Given the following constraints and requirements:

[Paste constraints]
[Paste requirements]

Generate architecture.md.

The document must:
- Define solution structure
- Define project/layer boundaries
- Define dependency rules
- Avoid coding standards
- Avoid AI behavior rules
```

## Output Characteristics
- Boundary-focused
- Layer-aware
- No line-level implementation

---

# Phase 4 – Establish Authority (governance.md)

## Goal
Define document hierarchy and conflict resolution.

## Anchor Prompt

```
Generate governance.md.

This file must:
- Define authority levels
- Define document precedence
- Define mandatory read order
- Define conflict resolution rules
- Avoid business logic
- Avoid architecture duplication
```

## Output Characteristics
- Root-level authority
- Minimal but explicit
- Stable over time

---

# Phase 5 – Define AI Behavior (copilot-instructions.md)

## Goal
Define how AI assistants must behave.

## Anchor Prompt

```
Generate copilot-instructions.md.

This document must:
- Define AI behavioral rules
- Reference governance.md as higher authority
- Forbid inventing requirements
- Forbid violating constraints
- Define refusal behavior when conflicts occur
- Avoid business logic and architecture duplication
```

## Output Characteristics
- Guardrail-focused
- Restrictive
- Clear about refusal conditions

After generation, refine inside Visual Studio using Copilot to align with actual repo structure.

---

# Phase 6 – Define Coding Standards (standards.md)

## Goal
Define code conventions.

## When to Generate
After the initial solution structure exists.

## Anchor Prompt (inside IDE)

```
Analyze the current solution.

Generate standards.md reflecting:
- Naming conventions
- Error handling patterns
- Logging patterns
- Dependency patterns

Do not invent new conventions.
Do not contradict governance or constraints.
```

## Output Characteristics
- Reflective of actual code
- Subordinate to higher authority files

---

# Phase 7 – Define Work Plan (tasks.md)

## Goal
Break current milestone into atomic steps.

## Anchor Prompt

```
Given the current requirements and architecture,
Generate tasks.md for the next milestone.

Tasks must:
- Be ordered
- Be atomic
- Not redefine requirements
- Not alter architecture
```

## Output Characteristics
- Temporary
- Execution-focused
- Replaceable

---

# Tool Allocation Strategy

| Document | Primary Tool | Reason |
|-----------|-------------|--------|
| constraints.md | General LLM | Boundary reasoning |
| requirements.md | General LLM | Structured specification |
| architecture.md | General LLM | System-level thinking |
| governance.md | General LLM | Policy reasoning |
| copilot-instructions.md | General LLM → Copilot refine | Behavioral clarity |
| standards.md | Copilot | Code-aware alignment |
| tasks.md | Copilot | Context execution |

---

# Operational Rules

1. Never generate documents out of order.
2. Never allow one document to absorb another’s responsibility.
3. Keep authority files stable.
4. Rotate focus documents during implementation.
5. Minimize pinned documents in the IDE.

---

# Success Criteria

The bootstrap is successful when:
- A new developer can clone the repo and understand authority immediately.
- Copilot behaves predictably without repeated prompting.
- Architecture drift does not occur during feature development.
- Requirements can evolve without breaking governance.

---

# Philosophy

Humans define intent.
AI executes within guardrails.
Governance prevents entropy.

This playbook exists to make AI behavior consistent, boring, and reliable.


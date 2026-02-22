# AI Bootstrap Playbook
## Unity + DLL + Multi-Solution Environment Edition

This edition of the AI Bootstrap Playbook is specifically tuned for environments with:

- Unity as the presentation layer
- One or more C# class library (DLL) projects
- Multiple Visual Studio solutions
- Shared core logic across projects
- Potential cross-platform targets (Desktop + Mobile)

The goal is to make AI assistance deterministic, scalable, and architecture-safe across all layers.

---

# 1. Architectural Assumptions

This structure assumes strict separation of concerns:

• Core (pure business logic, no Unity references)
• Infrastructure (data access, networking, storage)
• Application/Services (orchestration layer)
• Unity Presentation (UI only)
• Shared Contracts (DTOs, interfaces)

Unity must NEVER contain business logic.
DLLs must NEVER reference Unity.

---

# 2. Repository Structure (Drop-In Template)

```
/RepoRoot
  /docs
    governance.md
    requirements.md
    architecture.md
    constraints.md
    standards.md
    glossary.md
    decisions/
      ADR-001-structure.md

  /src
    /Core
      Core.csproj

    /Infrastructure
      Infrastructure.csproj

    /Application
      Application.csproj

    /Contracts
      Contracts.csproj

  /unity
    /UnityApp
      Assets/
      Packages/
      ProjectSettings/

  /tools

  copilot-instructions.md
  tasks.md
  README.md
```

---

# 3. Document Hierarchy (Authoritative Order)

AI Assistants must treat documents in this order of authority:

1. governance.md
2. constraints.md
3. architecture.md
4. standards.md
5. requirements.md
6. ADRs
7. tasks.md (ephemeral)

If any conflict occurs, higher authority wins.

---

# 4. Unity-Specific AI Guardrails

Add to governance.md:

• Unity is display-only
• No business rules in MonoBehaviours
• No direct database calls in Unity
• No infrastructure logic in presentation layer
• Communication through Application layer only

Add to constraints.md:

• Unity must consume compiled DLLs
• DLLs are built from /src only
• Unity never references /src projects directly
• Shared contracts are versioned

---

# 5. DLL Synchronization Strategy

For multi-Unity projects:

Option A – Post-build copy to central artifacts folder
Option B – Central artifact repository (network or CI pipeline)
Option C – NuGet-style private package feed

AI must never assume manual file copying.

Document this clearly in architecture.md.

---

# 6. Multi-Solution Scaling Pattern

Recommended solution layout:

• Core.sln (Core + Contracts)
• Infrastructure.sln (Infrastructure + Contracts)
• Application.sln (Application + Core + Contracts)
• UnityApp.sln (Unity-generated solution)

AI rule:
Each solution has a bounded context.
No solution may introduce upward dependency violations.

Add dependency rules explicitly to architecture.md.

---

# 7. Copilot + ChatGPT Role Specialization

Use assistants intentionally:

ChatGPT:
• Draft governance
• Draft architecture
• Generate ADRs
• Define constraints
• Threat modeling
• Scalability reasoning

Copilot (inside Visual Studio):
• Implement interfaces
• Fill method bodies
• Refactor
• Generate tests
• Enforce standards.md

Never rely on Copilot to invent architecture.
It must operate within pre-authored documents.

---

# 8. Anchor Prompts for Unity/DLL Environments

When bootstrapping documents, use anchor prompts.

For governance.md:
"Generate governance rules for a Unity presentation layer that consumes compiled C# business DLLs. Enforce strict architectural boundaries and prevent Unity logic leakage."

For architecture.md:
"Define a layered architecture for a Unity front-end consuming versioned C# DLLs with strict dependency rules and multi-solution separation."

For constraints.md:
"List technical constraints for Unity as UI-only with DLL-based business logic and offline-capable synchronization."

These anchor prompts stabilize AI reasoning before code exists.

---

# 9. Versioning & Change Control

Every structural change requires:

• ADR entry
• Architecture update
• Constraints validation
• Governance confirmation

AI must not generate structural refactors without ADR reference.

---

# 10. Scaling Checklist

When adding a new Unity project:

☐ Does it reference only compiled DLLs?
☐ Are contracts versioned?
☐ Is business logic isolated in Core?
☐ Are sync mechanisms documented?
☐ Is an ADR created if structure changes?

When adding a new DLL:

☐ Does it violate dependency rules?
☐ Is it referenced upward only?
☐ Are interfaces defined in Contracts?
☐ Is Unity unaffected?

---

# 11. AI Safety Layer Summary

This template prevents:

• Architecture drift
• Unity logic contamination
• Circular dependencies
• Copilot hallucinated cross-layer calls
• Multi-solution entropy

The documents are not documentation.
They are behavioral constraints for AI systems.

---

End of Unity + DLL + Multi-Solution Edition


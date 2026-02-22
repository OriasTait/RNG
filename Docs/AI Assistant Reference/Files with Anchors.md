As each of these documents serve a specific function for AI, how do we get each of the AI Assistants to help in the creation of these documents before the solution is built?  Are there specific anchor prompts that should be used to level set the conversations?



Yes.

If you want this to be repeatable (and not dependent on “good vibes prompting”), you need anchor prompts — not casual instructions.



What you’re doing is:



Bootstrapping an AI-governed repo before any code exists.



That requires:



Role framing



Output constraints



Authority awareness



Clear separation of concerns



Below is a pre-solution AI bootstrapping sequence that works reliably.



The Pre-Solution Governance Bootstrapping Model



You will create documents in this order:



glossary.md (see external reference)



constraints.md



requirements.md



architecture.md



governance.md



copilot-instructions.md



standards.md



tasks.md (last, and optional)



This order matters.



Constraints → Requirements → Architecture → Governance → Behavior → Standards → Tasks



The Anchor Prompt Pattern (Universal Template)



Before generating any document, start with this structure:



You are helping design an AI-governed software repository.



Your task is to generate ONLY the specified document.

Do not include content for any other file.

Do not assume implementation details beyond what is explicitly stated.



The document must:

\- Be self-contained

\- Be clear and enforceable

\- Avoid mixing concerns

\- Avoid redundancy with other governance files



Output only valid Markdown.





This levels the conversation.



Now we specialize per file.



1️⃣ constraints.md



(Generate first — defines reality)



Anchor Prompt

We are designing a software system with the following known facts:



\[List known technical facts here:

\- .NET 4.8

\- Unity 6.x

\- Offline capable

\- No cloud dependency

\- Windows + macOS

\- etc.]



Generate constraints.md.



This file must:

\- Contain only non-negotiable constraints

\- Avoid preferences

\- Avoid implementation details

\- Be written as hard requirements



Do not include architecture, standards, or behavioral instructions.





Why this works:



Forces the AI to separate fact from opinion



Prevents architectural leakage



Establishes guardrails before creativity begins



Use ChatGPT here.



2️⃣ requirements.md



(What the system must do)



Anchor Prompt

Using the constraints defined below:



\[Paste constraints]



Generate requirements.md.



This document must:

\- Define functional requirements

\- Define non-functional requirements

\- Clearly separate in-scope vs out-of-scope

\- Avoid architecture and implementation details



Do not reference governance or AI behavior.





Why this works:



Forces alignment with constraints



Prevents premature design



Keeps it business-level



Use ChatGPT.



3️⃣ architecture.md



(Structure without overreach)



Anchor Prompt

Given the following constraints and requirements:



\[Paste constraints]

\[Paste requirements]



Generate architecture.md.



The document must:

\- Define high-level solution structure

\- Define project boundaries (Core, Unity, Infrastructure, etc.)

\- Define dependency rules

\- Avoid coding standards

\- Avoid AI behavioral rules



This must remain implementation-agnostic where possible.





Use ChatGPT.



4️⃣ governance.md



(Authority and precedence)



Anchor Prompt

We are creating an AI-governed repository.



Generate governance.md.



This file must:

\- Define document hierarchy

\- Define conflict resolution rules

\- Define mandatory read order

\- Avoid functional requirements

\- Avoid architecture content

\- Avoid coding standards



It must be written as root authority.





Use ChatGPT.



5️⃣ copilot-instructions.md



(AI behavior rules)



Anchor Prompt

Generate copilot-instructions.md.



This document must:

\- Define how AI assistants must behave when modifying code

\- Reference governance.md as higher authority

\- Forbid inventing requirements

\- Forbid changing constraints

\- Define refusal behavior on conflict

\- Avoid business logic

\- Avoid architecture duplication



This file governs AI behavior only.





Use ChatGPT first, then refine in Visual Studio with Copilot.



6️⃣ standards.md



(Code style + conventions)



Now you switch tools.



Anchor Prompt (inside Visual Studio, after solution exists)

Analyze this solution.



Generate standards.md reflecting:

\- Naming conventions already used

\- Error handling patterns

\- Logging patterns

\- Dependency patterns



Do not invent new conventions.

Do not contradict governance or constraints.





This is Copilot’s job.



7️⃣ tasks.md



(Task decomposition)



Anchor Prompt

Given the current requirements and architecture,

generate tasks.md for the next implementation milestone.



Tasks must:

\- Be ordered

\- Be atomic

\- Not redefine requirements

\- Not change architecture





This can be Copilot or ChatGPT depending on context.



Why Anchor Prompts Work



They:



Assign role



Define scope



Prevent cross-contamination



Reduce hallucinated overlap



Force document purity



Without anchors, AI tends to:



Blend architecture into requirements



Add standards to governance



Add business logic to AI rules



Repeat itself



You’re preventing that up front.



The Meta-Anchor (optional but powerful)



At the start of a new AI session, use:



We are bootstrapping an AI-governed repository.



Each document serves a distinct authority level.

You must not mix responsibilities across documents.

If unclear, ask clarification questions before generating content.





This dramatically improves output quality.



Tool Assignment Summary

Document	Tool	Why

constraints.md	ChatGPT	Boundary reasoning

requirements.md	ChatGPT	Structured spec thinking

architecture.md	ChatGPT	System design reasoning

governance.md	ChatGPT	Policy reasoning

copilot-instructions.md	ChatGPT → Copilot refine	AI behavioral clarity

standards.md	Copilot	Code-aware alignment

tasks.md	Copilot (usually)	Context execution

The Big Insight



You are not prompting for content.



You are:



Establishing roles



Defining authority



Preventing scope bleed



Creating a deterministic AI conversation



Anchor prompts are not about better wording.



They are about:



Structuring the AI’s reasoning space before it starts generating.


    /* Notes:
     * The types in this file serve as the base type for all Registry types. 
     * They handle much of the inner workings of the various Registry systems
     * 
     * In general terms, a Registry is a mechanism used to interface between data based entries and in-game behaviour.
     * (In this context, Types are also considered to be data)
     * 
     * Note that all of this is very much at the fringe of what can be expressed through C#'s type system, so some rough edges are unavoidable.
     * 
     * A registry is split into three sections
     * 
     * The Registry type - A static/singleton interface over all the functionality and the way behaviours unique to some registry are implemented
     * The Def type - The type that is stored by the registry
     * The Backend type - The type that provides the location to store the Defs
     * 
     * MetaRegistry is an implementation of a Registry that manages all other Registrys. It handles loading order, hot reloading, and procedural entries.
     *  If you are looking to add a registry (and it is not part of this project) you need to call RegistryInitializer.Init<TRegistry, TDef, TBackend>()
     *  (if the new registry is part of this project, that call is generated automatically from syntax analysis of all type declarations in the project, so you just need to define it)
     * 
     * Registry<TRegistry, TDef> is a simplified interface that abstracts away the need to define a backend for the registry. 
     * This is what should be used when you want to add a new system, not wrap an existing one.
     * 
     * Registry<TRegistry, TDef, TBackend> is the main implementation of the system. 
     *  It is big, scary, and full of generics.
     *  It is also the type that performs the transformation from instance data to static data
     * 
     * Registry represents the instance data of a Registry.
     *  it is used as the Def type in MetaRegistry, and also serves as the ultimate base class for all Registry types, including MetaRegistry.
     *  
     *  
     *  
     * Nested type notes:
     *  IRegistryBackend is the interface for implementing a backend. It needs to provide a place to store the active elements
     *  
     *  IRegistryDef is the ultimate base of all definition types, a registry can also implement a custom type and force defs to be based upon that instead.
     *  
     *  Index is... an index. The enum itself is nested, and thus allows the enum type to carry around the type info of the registry at compile time. This enables the use of type safe extension methods on them.
     *  
     *  Element represents a "slot" in the registry. In most cases it will be active. There is always a single Element for every unique def guid, never more or less.
     *      Element should be used to store persistent references to a particular def
     *      They also are the mechanism through which overrides occur, in the case of a def being added that shares a guid with an existing def, the entry is updated to point to the new def instead.
     *          While the override mechanism does introduce some burden to users to adhere to a sane naming scheme such as Author.ModName.UniqueToModGuidForDef, this drastically improves range of functionality
     *          
     *  RegistrationToken is used as a handle over a def that has been added. It provides the ability to unregister and reregister, as well as check the status of that specific def.
     *  
     * Procedural stuff:
     *  Procedural defs are defined as being defs that are added to a registry after that registry has run its first pass of element generation, but before metaregistry has finished its full init process.
     *  The only exposed way to run code during this time is through events.
     *  Whenever this occurs, the added def is added to a queue. Once the current pass over the registries is completed, metaregistry will count the number of items in the procedural queue for each registry and run through them in order
     *  This will repeat until every registry reports no procedural defs have been added.
     *  This does expose potential for infinite looping, so logging will be crucial when the procedural defs are being added.
     */
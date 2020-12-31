CREATE TABLE domain (
    id              BIGINT,

    code            TEXT            NOT NULL,
    description     TEXT            NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE project (
    id              BIGINT,

    name            TEXT            NOT NULL,
    description     TEXT            NOT NULL,
    domain_id       BIGINT          NOT NULL,
    curr_version_id BIGINT          NOT NULL,

    is_delete       BOOLEAN         NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE version (
    id              BIGINT,

    name            TEXT            NOT NULL,
    description     TEXT            NOT NULL,
    project_id      BIGINT          NOT NULL,
    base_version_id BIGINT          NOT NULL,
    
    is_stable       BOOLEAN         NOT NULL,
    
    is_delete       BOOLEAN         NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE doc_tree (
    id              BIGINT,
    bid             BIGINT          NOT NULL,
    
    parent_id       BIGINT          NOT NULL,

    doc_bid         BIGINT          NOT NULL,
    doc_metadata_id BIGINT          NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE doc (
    id              BIGINT,

    name            TEXT            NOT NULL,
    type            TEXT            NOT NULL,
    metadata        TEXT            NOT NULL,
    description     TEXT            NOT NULL,

    bid             BIGINT          NOT NULL,
    operate_type    BIGINT          NOT NULL,
    operate_time    TIMESTAMPTZ     NOT NULL,
    operate_user_id BIGINT          NOT NULL,

    PRIMARY KEY (id)
);